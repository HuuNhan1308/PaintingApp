using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
        void getPathsData(List<Shape> shapes)
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
        public void delSingleComponentFromMain(List<Shape> mainListShapes)
        {
            foreach (var shape in shapes)
                mainListShapes.Remove(shape);
        }

        public GroupOfShape(List<Shape> shapes) 
        {
            this.shapes = new List<Shape>(shapes);
            this.getPathsData(this.shapes);


            //get startPoint and endPoint
            float minX, minY, maxX, maxY;
            minX = minY = int.MaxValue;
            maxX = maxY = 0;
            foreach(Shape shape in this.shapes)
            {
                minX = shape.startPoint.X < minX ? shape.startPoint.X : minX;
                minY = shape.startPoint.Y < minY ? shape.startPoint.Y : minY;

                maxX = shape.endPoint.X > maxX ? shape.endPoint.X : maxX;
                maxY = shape.endPoint.Y > maxY ? shape.endPoint.Y : maxY;

            }

            this.startPoint = new PointF(minX, minY);
            this.endPoint = new PointF(maxX, maxY);

        }


        public override GraphicsPath GetPath => throw new NotImplementedException();

        public override void Draw(Graphics Gra)
        {
            //draw all the shape in list
            for(int i = 0; i< shapes.Count; i++)
            {
                if (shapes[i].IsFill)
                    using (Brush myBrush = new SolidBrush(this.ShapeColor))
                    {
                        Gra.FillPath(myBrush, paths[i]);
                    }
                else if (shapes[i] is GroupOfShape groupShapes)
                    groupShapes.Draw(Gra);
                else
                    using (Pen myPen = new Pen(shapes[i].BorderColor, shapes[i].Width)
                    { DashStyle = shapes[i].ShapeDashStyle})
                    {
                        Gra.DrawPath(myPen, paths[i]);
                    }
            }
        }

        public override bool IsHit(PointF Point)
        {
            bool result = false;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsFill && paths[i].IsVisible(Point))
                    return true;
                else if (shapes[i] is GroupOfShape groupShapes)
                    groupShapes.IsHit(Point);
                else if (!shapes[i].IsFill)
                {
                    using (Pen MyPen = new Pen(ShapeColor, Width + 2))
                        result = paths[i].IsOutlineVisible(Point, MyPen);
                    if (result) return true;
                }
            }

            return result;
        }

        public override void Move(PointF Dis)
        {
            foreach(var shape in shapes)
            {
                shape.startPoint = new PointF(shape.startPoint.X + Dis.X, shape.startPoint.Y + Dis.Y);
                shape.endPoint = new PointF(shape.endPoint.X + Dis.X, shape.endPoint.Y + Dis.Y);
                Console.WriteLine(shape.ToString()+ ": " + shape.startPoint + " " + shape.endPoint);
            }
            this.startPoint = new PointF(startPoint.X + Dis.X, startPoint.Y + Dis.Y);
            this.endPoint = new PointF(endPoint.X + Dis.X, endPoint.Y + Dis.Y);
        }
    }
}