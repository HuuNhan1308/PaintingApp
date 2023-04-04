using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MIDTERM_WINFORM_PAINT
{
    public class Polygon : Shape
    {
        public List<PointF> Vertices = new List<PointF>();
        bool completedVertices = false;

        public PointF BorderStartPoint
        {
            //get the start point of outline rectangle
            get
            {
                float minX, minY;
                minX = minY = int.MaxValue;

                foreach (var point in this.Vertices)
                {
                    //lay ra hinh chu nhat outline cua polygon


                    minX = Math.Min(minX, Math.Min(point.X, point.X));
                    minY = Math.Min(minY, Math.Min(point.Y, point.Y));

                }

                return new PointF(minX, minY);
            }
        }

        public PointF BorderEndPoint
        {
            //get the end point of the outline rectangle
            get
            {
                float maxX, maxY;
                maxX = maxY = 0;
                foreach (var point in this.Vertices)
                {

                    maxX = Math.Max(maxX, Math.Max(point.X, point.X));
                    maxY = Math.Max(maxY, Math.Max(point.Y, point.Y));
                }

                return new PointF(maxX, maxY);
            }
        }

        public Polygon() 
         {
            this.Name = "Polygon";
        }

        public Polygon(PointF StartPoint, PointF EndPoint, float Width, Color ShapeColor, DashStyle ShapeDastStyle, bool IsFill)
            : base(StartPoint, EndPoint, Width, ShapeColor, ShapeDastStyle)
        {
            this.Name = "Rectangle";
            this.IsFill = IsFill;
            this.BorderColor = ShapeColor;
            this.Vertices.Add(StartPoint);
            this.Vertices.Add(EndPoint);
            this.Vertices.Add(EndPoint);

        }

        public override GraphicsPath GetPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(this.Vertices.ToArray());

                //optimizing hehehe
                if (this.Vertices.Count > 4 && !this.completedVertices)
                {
                    this.completedVertices = !this.completedVertices;
                    this.Vertices.RemoveRange(0, 1);
                }

                return path;
            }
        }

        public override void Draw(Graphics Gra)
        {
            using (GraphicsPath path = GetPath)
            {
                using (Pen myPen = new Pen(BorderColor, Width))
                {
                    myPen.DashStyle = this.ShapeDashStyle;
                    Gra.DrawPath(myPen, path);
                }
                if (this.IsFill)
                {
                    using (Brush myBrush = new SolidBrush(this.ShapeColor))
                    {
                        Gra.FillPath(myBrush, path);
                    }
                }
            }
        }

        public override bool IsHit(PointF Point)
        {
            bool result = false;
            using (GraphicsPath path = GetPath)
            {
                if (!IsFill)
                {
                    using (Pen MyPen = new Pen(ShapeColor, Width + 2))
                    {
                        result = path.IsOutlineVisible(Point, MyPen);
                    }
                }
                else
                {
                    result = path.IsVisible(Point);
                }
            }
            return result;
        }

        public override void Move(PointF Dis)
        {
            for(int i = 0; i < this.Vertices.Count; ++i)
                this.Vertices[i] = new PointF(Vertices[i].X + Dis.X, Vertices[i].Y + Dis.Y);
        }
    }
}