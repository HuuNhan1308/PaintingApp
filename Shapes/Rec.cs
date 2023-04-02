using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MIDTERM_WINFORM_PAINT
{
    public class Rec : Shape
    {
        public Rec()
        {
            this.Name = "Rectangle";
        }
        public Rec(PointF startPoint, PointF endPoint, float Width, Color ShapeColor , DashStyle ShapeDastStyle, bool IsFill) 
            : base(startPoint, endPoint, Width, ShapeColor, ShapeDastStyle)
        {
            this.Name = "Rectangle";
            this.IsFill = IsFill;
            this.BorderColor = ShapeColor;
        }

        public override GraphicsPath GetPath 
        {
            get
            {
                GraphicsPath GPath = new GraphicsPath();
                RectangleF r = new RectangleF(Math.Min(startPoint.X, endPoint.X),
                            Math.Min(startPoint.Y, endPoint.Y),
                            Math.Abs(endPoint.X - startPoint.X),
                            Math.Abs(endPoint.Y - startPoint.Y));
                GPath.AddRectangle(r);
                return GPath;
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
        public override void Move(PointF Dis)
        {
            startPoint = new PointF(startPoint.X + Dis.X, startPoint.Y + Dis.Y);
            endPoint = new PointF(endPoint.X + Dis.X, endPoint.Y + Dis.Y);
        }
    }
}