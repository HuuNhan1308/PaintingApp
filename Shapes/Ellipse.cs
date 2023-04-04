using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MIDTERM_WINFORM_PAINT
{
    public class Ellipse : Shape
    {
        public Ellipse(PointF StartPoint, PointF EndPoint, float Width, Color ShapeColor, DashStyle ShapeDashStyle, bool isFill)
            : base(StartPoint, EndPoint, Width, ShapeColor, ShapeDashStyle)
        {
            this.Name = "Ellipse";
            this.IsFill = isFill;
            this.BorderColor = ShapeColor;
        }

        public override GraphicsPath GetPath 
        {
            get
            {
                GraphicsPath GPath = new GraphicsPath();
                RectangleF r = new RectangleF(Math.Min(StartPoint.X, EndPoint.X),
                            Math.Min(StartPoint.Y, EndPoint.Y),
                            Math.Abs(EndPoint.X - StartPoint.X),
                            Math.Abs(EndPoint.Y - StartPoint.Y));

                GPath.AddEllipse(r);
                return GPath;
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
            StartPoint = new PointF(StartPoint.X + Dis.X, StartPoint.Y + Dis.Y);
            EndPoint = new PointF(EndPoint.X + Dis.X, EndPoint.Y + Dis.Y);
        }

        public override void Resize(Graphics Gra)
        {
            RectangleF StartPointOffset = new RectangleF(startPoint.X - 5, startPoint.Y - 5, 10, 10);
            RectangleF EndPointOffset= new RectangleF(endPoint.X - 5, endPoint.Y - 5, 10, 10);

            
        }
    }
}