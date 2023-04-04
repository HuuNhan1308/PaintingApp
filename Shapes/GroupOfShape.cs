using System;
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
                    pathSingleShape.AddLine(line.StartPoint, line.EndPoint);
                else if (shape is Rec rec)
                    pathSingleShape.AddRectangle(new RectangleF(rec.StartPoint.X, rec.StartPoint.Y,
                        rec.EndPoint.X - rec.StartPoint.X, rec.EndPoint.Y - rec.StartPoint.Y));
                else if (shape is Polygon polygon)
                    pathSingleShape.AddPolygon(polygon.Vertices.ToArray());

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
                //if (shape is GroupOfShape groupOfShape) groupOfShape.getStartEndPoint(ref StartPoint,ref EndPoint);
                if (shape is Polygon polygon)
                {
                    minX = Math.Min(minX, polygon.BorderStartPoint.X);
                    minY = Math.Min(minX, polygon.BorderStartPoint.Y);

                    maxX = Math.Max(maxX, polygon.BorderEndPoint.X);
                    maxY = Math.Max(maxY, polygon.BorderEndPoint.Y);
                }
                else
                {
                    minX = Math.Min(minX, Math.Min(shape.StartPoint.X, shape.EndPoint.X));
                    minY = Math.Min(minY, Math.Min(shape.StartPoint.Y, shape.EndPoint.Y));

                    maxX = Math.Max(maxX, Math.Max(shape.StartPoint.X, shape.EndPoint.X));
                    maxY = Math.Max(maxY, Math.Max(shape.StartPoint.Y, shape.EndPoint.Y));
                }
            }

            this.StartPoint = new PointF(minX, minY);
            this.EndPoint = new PointF(maxX, maxY);
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
                if (shapes[i] is GroupOfShape groupShapes) result =  groupShapes.IsHit(Point);
                else
                {
                    result = shapes[i].IsHit(Point);
                }
                    if (result) return result;
            }

            return false;
        }

        public override void Move(PointF Dis)
        {
            //move each component in group
            foreach(var shape in shapes)
            {
                if (shape is GroupOfShape groupShapes) groupShapes.Move(Dis);
                else if (shape is Polygon polygon) polygon.Move(Dis);
                else
                {
                    shape.StartPoint = new PointF(shape.StartPoint.X + Dis.X, shape.StartPoint.Y + Dis.Y);
                    shape.EndPoint = new PointF(shape.EndPoint.X + Dis.X, shape.EndPoint.Y + Dis.Y);
                }
            }

            //move start point and end point to change outline location
            this.StartPoint = new PointF(StartPoint.X + Dis.X, StartPoint.Y + Dis.Y);
            this.EndPoint = new PointF(EndPoint.X + Dis.X, EndPoint.Y + Dis.Y);
        }

        public void Ungroup(ref List<Shape> mainListShapes)
        {
            //add data back to main list
            foreach(var shape in shapes) mainListShapes.Add(shape);

            //delete group shape in main list
            mainListShapes.Remove(this);

        }

        public override void Resize(Graphics Gra)
        {
            throw new NotImplementedException();
        }
    }
}