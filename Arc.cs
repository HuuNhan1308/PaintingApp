using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MIDTERM_WINFORM_PAINT
{
    public class Arc : Line
    {
        public Arc()
        {
            this.Name = "Arc";
        }
        public Arc(PointF StartPoint, PointF EndPoint, float Width, Color ShapeColor, DashStyle ShapeDashStyle)
            : base(StartPoint, EndPoint, Width, ShapeColor, ShapeDashStyle)
        {
            this.Name = "Arc";
        }

        public int SweepAngle { get; set; }
        private bool IsChecked { get; set; } = false;

        public override GraphicsPath GetPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (IsChecked == false)
                {
                    SweepAngle = -180;
                    if (StartPoint.Y >= EndPoint.Y)
                    {
                        SweepAngle = 180;
                    }
                    if (Math.Abs(EndPoint.Y - StartPoint.Y) == 0 && Math.Abs(EndPoint.X - StartPoint.X) == 0)
                    {
                        RectangleF r = new RectangleF(
                         Math.Min(StartPoint.X, EndPoint.X),
                         Math.Min(StartPoint.Y, EndPoint.Y),
                         Math.Abs(EndPoint.X - StartPoint.X + 10),
                         Math.Abs(EndPoint.Y - StartPoint.Y + 10));
                        path.AddArc(r, 0, SweepAngle);
                    }
                    else if (Math.Abs(EndPoint.Y - StartPoint.Y) == 0)
                    {
                        RectangleF r = new RectangleF(
                         Math.Min(StartPoint.X, EndPoint.X),
                         Math.Min(StartPoint.Y, EndPoint.Y),
                         Math.Abs(EndPoint.X - StartPoint.X),
                         Math.Abs(EndPoint.Y - StartPoint.Y + 10));
                        path.AddArc(r, 0, SweepAngle);
                    }
                    else if (Math.Abs(EndPoint.X - StartPoint.X) == 0)
                    {
                        RectangleF r = new RectangleF(
                        Math.Min(StartPoint.X, EndPoint.X),
                        Math.Min(StartPoint.Y, EndPoint.Y),
                        Math.Abs(EndPoint.X - StartPoint.X + 10),
                        Math.Abs(EndPoint.Y - StartPoint.Y));
                        path.AddArc(r, 0, SweepAngle);
                    }
                    else
                    {
                        RectangleF r = new RectangleF(
                          Math.Min(StartPoint.X, EndPoint.X),
                          Math.Min(StartPoint.Y, EndPoint.Y),
                          Math.Abs(EndPoint.X - StartPoint.X),
                          Math.Abs(EndPoint.Y - StartPoint.Y));
                        path.AddArc(r, 0, SweepAngle);
                    }
                }
                else
                {
                    RectangleF r = new RectangleF(
                          Math.Min(StartPoint.X, EndPoint.X),
                          Math.Min(StartPoint.Y, EndPoint.Y),
                          Math.Abs(EndPoint.X - StartPoint.X),
                          Math.Abs(EndPoint.Y - StartPoint.Y));
                    if (r.Width == 0 || r.Height == 0) // Trường hợp vẽ arc chỉ chấm 1 điểm
                    {
                        r.Width = 10;
                        r.Height = 10;
                    }
                    path.AddArc(r, 0, SweepAngle);
                }
                return path;
            }
        }
    }
}