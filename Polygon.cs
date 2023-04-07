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
            set
            {
                
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
            this.Vertices.Add(StartPoint);
            this.Vertices.Add(StartPoint);

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

        public override void Resize(Graphics Gra)
        {
            throw new NotImplementedException();
        }

        public void SizeUP()
        {
            List<PointF> tmp = new List<PointF>();
            tmp.Add(Vertices[0]);
            Console.WriteLine("p[" + 0 + "]: " + Vertices[0]);
            int len = Vertices.Count();
            if (len > 2)
            {
                for (int i = 1; i < len; i++)
                {
                    Console.WriteLine("p[" + i + "]: " + Vertices[i]);
                    //finding dx [0] and [i]
                    float x = -Vertices[0].Y + Vertices[i].Y;
                    float y = Vertices[0].X - Vertices[i].X;
                    float dx1 = (float)x / y;
                    Console.WriteLine("Dx1 0-" + i + ": " + dx1);
                    if (i == 1)
                    {
                        PointF p2 = new PointF(this.Vertices[i].X + 3, this.Vertices[i].Y - (3 * dx1));
                        tmp.Add(p2);
                        Console.WriteLine("p[" + i + "]': " + tmp[i]);
                    }
                    else
                    {
                        x = -Vertices[i - 1].Y + Vertices[i].Y;
                        y = Vertices[i - 1].X - Vertices[i].X;
                        float dx2 = (float)x / y;
                        Console.WriteLine("Dx1 " + (i - 1) + " - " + i + ": " + dx2);
                        x = dx2 * (-tmp[i - 1].X) - tmp[i - 1].Y + dx1 * (Vertices[0].X) + Vertices[0].Y;
                        x /= (dx1 - dx2);
                        Console.WriteLine(x);
                        y = -dx1 * (x - Vertices[0].X) + Vertices[0].Y;
                        Console.WriteLine(y);
                        PointF p2 = new PointF(x, y);
                        tmp.Add(p2);
                        Console.WriteLine("p[" + i + "]': " + tmp[i]);
                    }
                }
                for (int i = 0; i < len; i++)
                    Vertices[i] = tmp[i];
            }
            else
            {
                float x = -Vertices[0].Y + Vertices[1].Y;
                float y = Vertices[0].X - Vertices[1].X;
                float dx1 = (float)x / y;
                Console.WriteLine("Dx1 0-" + 1 + ": " + dx1);
                PointF p2 = new PointF(this.Vertices[1].X + 3, this.Vertices[1].Y - (3 * dx1));
                Vertices[1] = p2;
            }
        }
        public void SizeDW()
        {
            bool flag = true;
            List<PointF> tmp = new List<PointF>();
            tmp.Add(Vertices[0]);
            Console.WriteLine("p[" + 0 + "]: " + Vertices[0]);
            int len = Vertices.Count();
            if (len > 2)
            {
                for (int i = 1; i < len; i++)
                {
                    Console.WriteLine("p[" + i + "]: " + Vertices[i]);
                    //finding dx [0] and [i]
                    float x = -Vertices[0].Y + Vertices[i].Y;
                    float y = Vertices[0].X - Vertices[i].X;
                    float dx1 = (float)x / y;
                    Console.WriteLine("Dx1 0-" + i + ": " + dx1);
                    if (i == 1)
                    {
                        PointF p2 = new PointF(this.Vertices[i].X - 3, this.Vertices[i].Y + (3 * dx1));
                        float check = this.Vertices[i].X - 3 - this.Vertices[0].X;
                        if (check > 5)
                        {
                            tmp.Add(p2);
                            Console.WriteLine("p[" + i + "]': " + tmp[i]);
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        x = -Vertices[i - 1].Y + Vertices[i].Y;
                        y = Vertices[i - 1].X - Vertices[i].X;
                        float dx2 = (float)x / y;
                        Console.WriteLine("Dx1 " + (i - 1) + " - " + i + ": " + dx2);
                        x = dx2 * (-tmp[i - 1].X) - tmp[i - 1].Y + dx1 * (Vertices[0].X) + Vertices[0].Y;
                        x /= (dx1 - dx2);
                        Console.WriteLine(x);
                        y = -dx1 * (x - Vertices[0].X) + Vertices[0].Y;
                        Console.WriteLine(y);
                        PointF p2 = new PointF(x, y);
                        tmp.Add(p2);
                        Console.WriteLine("p[" + i + "]': " + tmp[i]);
                    }
                }
                if (flag == true)
                    for (int i = 0; i < len; i++)
                        Vertices[i] = tmp[i];
            }
            else
            {
                float check = this.Vertices[1].X - 10 - this.Vertices[0].X;
                if (check > 5)
                {
                    float x = -Vertices[0].Y + Vertices[1].Y;
                    float y = Vertices[0].X - Vertices[1].X;
                    float dx1 = (float)x / y;
                    Console.WriteLine("Dx1 0-" + 1 + ": " + dx1);
                    PointF p2 = new PointF(this.Vertices[1].X - 3, this.Vertices[1].Y + (3 * dx1));
                    Vertices[1] = p2;
                }
            }
        }
    }
}