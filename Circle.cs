using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MIDTERM_WINFORM_PAINT
{
    public class Circle : Ellipse
    {
        public Circle(PointF StartPoint, PointF EndPoint, float Width, Color ShapeColor, DashStyle ShapeDashStyle, bool isFill, Color BorderColor)
            : base(StartPoint, EndPoint, Width, ShapeColor, ShapeDashStyle, isFill, BorderColor)
        {
            this.Name = "Circle";
            this.IsFill = isFill;
            this.BorderColor = BorderColor;
            this.ShapeColor = ShapeColor;
        }

        public override GraphicsPath GetPath
        {
            get
            {
                GraphicsPath GPath = new GraphicsPath();
                float Diameter = ((EndPoint.X - StartPoint.X) + (EndPoint.Y - StartPoint.Y)) / 2;
                GPath.AddEllipse(new RectangleF(StartPoint.X, StartPoint.Y, Diameter, Diameter));
                EndPoint = new PointF(StartPoint.X + Diameter, StartPoint.Y + Diameter);
                return GPath;
            }
        }
    }
}