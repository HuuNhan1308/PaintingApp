using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MIDTERM_WINFORM_PAINT
{
    public class Line : Shape
    {
        public Line()
        {
            this.Name = "Line";
        }
        public Line(PointF startPoint, PointF endPoint, float Width, Color ShapeColor, DashStyle ShapeDashStyle)
            : base(startPoint, endPoint, Width, ShapeColor, ShapeDashStyle)
        {
            this.Name = "Line";
        }
        public override GraphicsPath GetPath
        {
            get
            {
                GraphicsPath GPath = new GraphicsPath();
                GPath.AddLine(startPoint, endPoint);
                return GPath;
            }
        }
        public override bool IsHit(PointF Point)
        {
            bool result = false;
            using (GraphicsPath path = GetPath)
            {
                using (Pen MyPen = new Pen(BorderColor, Width + 2))
                {
                    result = path.IsOutlineVisible(Point, MyPen);
                }
            }

            Console.WriteLine(result ? "Hit the line" : "No hit");
            return result;
        }
        public override void Draw(Graphics Gra)
        {
            using (GraphicsPath path = GetPath)
            {
                using (Pen myPen = new Pen(ShapeColor, Width))
                {
                    myPen.DashStyle = this.ShapeDashStyle;
                    Gra.DrawPath(myPen, path);
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