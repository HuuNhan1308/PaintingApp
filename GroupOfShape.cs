using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIDTERM_WINFORM_PAINT
{
    public class GroupOfShape : Shape
    {
        public List<Shape> shapes = new List<Shape>();
        
        private List<GraphicsPath> paths = new List<GraphicsPath>();

        //support function
        //
        void getPathsData(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                GraphicsPath pathSingleShape = new GraphicsPath();

                if (shape is Line line)
                    pathSingleShape.AddLine(line.startPoint, line.endPoint);
                else if (shape is Rec rec)
                    pathSingleShape.AddRectangle(new RectangleF(rec.startPoint.X, rec.startPoint.Y,
                        rec.endPoint.X - rec.startPoint.X, rec.endPoint.Y - rec.startPoint.Y));

                paths.Add(pathSingleShape);
            }
        }

        public GroupOfShape(List<Shape> shapes) 
        {
            this.shapes = shapes;
            this.getPathsData(shapes);
        }


        public override GraphicsPath GetPath => throw new NotImplementedException();

        public override void Draw(Graphics Gra)
        {
            //draw all the shape in list
            foreach(GraphicsPath path in paths)
            {
                
            }
        }

        public override bool IsHit(PointF Point)
        {
            throw new NotImplementedException();
        }

        public override void Move(PointF Dis)
        {
            throw new NotImplementedException();
        }
    }
}