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

        public Polygon() 
         {
            this.Name = "Polygon";
        }

        public Polygon(PointF startPoint, PointF endPoint, float Width, Color ShapeColor, DashStyle ShapeDastStyle, bool IsFill)
            : base(startPoint, endPoint, Width, ShapeColor, ShapeDastStyle)
        {
            this.Name = "Rectangle";
            this.IsFill = IsFill;
            this.BorderColor = ShapeColor;
            this.Vertices.Add(startPoint);
            this.Vertices.Add(endPoint);

        }

        public override GraphicsPath GetPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (this.Vertices.Count < 3)
                    path.AddLine(startPoint, endPoint);
                else
                    path.AddPolygon(this.Vertices.ToArray());

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