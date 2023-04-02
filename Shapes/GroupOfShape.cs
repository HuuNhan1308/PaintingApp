﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace MIDTERM_WINFORM_PAINT
{
    public class GroupOfShape : Shape
    {

        
        public override string ToString()
        {
            return "Group Shape";
        }
        public List<Shape> shapes;
        private List<GraphicsPath> paths = new List<GraphicsPath>();

        //support function
        //
        private void getPathsData(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                GraphicsPath pathSingleShape = new GraphicsPath();

                if (shape is Line line)
                    pathSingleShape.AddLine(line.startPoint, line.endPoint);
                else if (shape is Rec rec)
                    pathSingleShape.AddRectangle(new RectangleF(rec.startPoint.X, rec.startPoint.Y,
                        rec.endPoint.X - rec.startPoint.X, rec.endPoint.Y - rec.startPoint.Y));

                paths.Add(pathSingleShape);
            }
        }
        public void delSingleComponentFromMain(ref List<Shape> mainListShapes)
        {
            foreach (var shape in shapes)
                mainListShapes.Remove(shape);
        }
        private void getStartEndPoint()
        {
            float minX, minY, maxX, maxY;
            minX = minY = int.MaxValue;
            maxX = maxY = 0;
            foreach (Shape shape in this.shapes)
            {
                if (shape is GroupOfShape groupOfShape) groupOfShape.getStartEndPoint();

                //minX = shape.startPoint.X < minX ? shape.startPoint.X : minX;
                //minY = shape.startPoint.Y < minY ? shape.startPoint.Y : minY;

                //maxX = shape.endPoint.X > maxX ? shape.endPoint.X : maxX;
                //maxY = shape.endPoint.Y > maxY ? shape.endPoint.Y : maxY;


                minX = Math.Min(minX, Math.Min(shape.startPoint.X, shape.endPoint.X));
                minY = Math.Min(minY, Math.Min(shape.startPoint.Y, shape.endPoint.Y));

                maxX = Math.Max(maxX, Math.Max(shape.startPoint.X, shape.endPoint.X));
                maxY = Math.Max(maxY, Math.Max(shape.startPoint.Y, shape.endPoint.Y));
            }

            this.startPoint = new PointF(minX, minY);
            this.endPoint = new PointF(maxX, maxY);
        }
        //------------------------------------


        public GroupOfShape(List<Shape> shapes) 
        {
            this.shapes = new List<Shape>(shapes);
            this.getPathsData(this.shapes);
            this.getStartEndPoint();
        }

        public override GraphicsPath GetPath => throw new NotImplementedException();

        public override void Draw(Graphics Gra)
        {
            //draw all the shape in list
            for(int i = 0; i< shapes.Count; i++)
            {
                if (shapes[i] is GroupOfShape groupShapes)
                    groupShapes.Draw(Gra);
                else
                    shapes[i].Draw(Gra);
            }
        }

        public override bool IsHit(PointF Point)
        {
            bool result = false;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is GroupOfShape groupShapes) return groupShapes.IsHit(Point);
                else
                {
                    result = shapes[i].IsHit(Point);
                    if (result) return result;
                }
            }

            return false;
        }

        public override void Move(PointF Dis)
        {
            //move each component in group
            foreach(var shape in shapes)
            {
                if (shape is GroupOfShape groupShapes) groupShapes.Move(Dis);
                else
                {
                    shape.startPoint = new PointF(shape.startPoint.X + Dis.X, shape.startPoint.Y + Dis.Y);
                    shape.endPoint = new PointF(shape.endPoint.X + Dis.X, shape.endPoint.Y + Dis.Y);
                }
            }

            //move start point and end point to change outline location
            this.startPoint = new PointF(startPoint.X + Dis.X, startPoint.Y + Dis.Y);
            this.endPoint = new PointF(endPoint.X + Dis.X, endPoint.Y + Dis.Y);
        }

        public void Ungroup(ref List<Shape> mainListShapes)
        {
            //add data back to main list
            foreach(var shape in shapes) mainListShapes.Add(shape);

            //delete group shape in main list
            mainListShapes.Remove(this);

        }
    }
}