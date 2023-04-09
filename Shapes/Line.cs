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
        public Line(PointF StartPoint, PointF EndPoint, float Width, Color ShapeColor, DashStyle ShapeDashStyle)
            : base(StartPoint, EndPoint, Width, ShapeColor, ShapeDashStyle)
        {
            this.Name = "Line";
        }
        public override GraphicsPath GetPath
        {
            get
            {
                GraphicsPath GPath = new GraphicsPath();
                GPath.AddLine(StartPoint, EndPoint);
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
            StartPoint = new PointF(StartPoint.X + Dis.X, StartPoint.Y + Dis.Y);
            EndPoint = new PointF(EndPoint.X + Dis.X, EndPoint.Y + Dis.Y);
        }

        public override void Resize(Graphics Gra)
        {
            throw new NotImplementedException();
        }
    }
}