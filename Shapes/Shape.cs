using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MIDTERM_WINFORM_PAINT
{
    public abstract class Shape
    {

        public Shape()
        {
        }
        public Shape(PointF StartPoint, PointF EndPoint, float Width, Color ShapeColor, DashStyle ShapeDashStyle)
        {
            this.StartPoint = StartPoint;
            this.EndPoint = EndPoint;
            this.Width = Width;
            this.ShapeColor = ShapeColor;
            this.ShapeDashStyle = ShapeDashStyle;
        }

        protected PointF startPoint;
        protected PointF endPoint;

        //--------------------------

        public PointF PreviousPoint = Point.Empty;
        public string Name { get; set; }
        public PointF StartPoint { get => this.startPoint; set => this.startPoint = value; }
        public PointF EndPoint { get => this.endPoint; set => this.endPoint = value; }
        public float Width { get; set; }
        public bool IsFill { get; set; } = false;
        public Color BorderColor { get; set; }
        public Color ShapeColor { get; set; }
        public DashStyle ShapeDashStyle { get; set; }
        public abstract GraphicsPath GetPath { get; }
        public bool isShowOutline { get; set; } = false;
        

        public abstract void Draw(Graphics Gra);
        public abstract void Move(PointF Dis);
        public abstract bool IsHit(PointF Point);

    }
}