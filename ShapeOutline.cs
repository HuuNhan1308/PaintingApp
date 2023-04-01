using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MIDTERM_WINFORM_PAINT
{


    public static class ShapeOutline
    {
        public static Brush MovingBrush = new SolidBrush(Color.FromArgb(0, 30, 81));
        public static Brush MovingShadow = new SolidBrush(Color.White);
        public static void DrawOutlineSelected(this Graphics gp, PointF p1, PointF p2)
        {
            Pen dashPenShadow = new Pen(Color.FromArgb(240,240,240));
            dashPenShadow.DashStyle = DashStyle.Dash;
            dashPenShadow.Width = 2;
            gp.DrawRectangle(dashPenShadow, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
        }

        public static void DrawSelectedPoint(Graphics gp, PointF p1, PointF p2)
        {
            //gp.FillEllipse(ShapeOutline.MovingShadow, new RectangleF(p1.X - 5, p1.Y - 5, 12, 12));
            //gp.FillEllipse(ShapeOutline.MovingShadow, new RectangleF(p2.X - 5, p2.Y - 5, 12, 12));
            gp.FillEllipse(ShapeOutline.MovingBrush, new RectangleF(p1.X - 5, p1.Y - 5, 10, 10));
            gp.FillEllipse(ShapeOutline.MovingBrush, new RectangleF(p2.X - 5, p2.Y - 5, 10, 10));
        }
    }
}