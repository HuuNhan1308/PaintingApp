﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;


//Dang lam chuc nang group trong class group of shape

namespace MIDTERM_WINFORM_PAINT
{
    public partial class PaintingApp : Form
    {
        public PaintingApp()
        {
            InitializeComponent();
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        //Pen MyPen;
        //Graphics gp;
        Color myColor = Color.Blue;
        Color borderColor = Color.Green;
        DashStyle ShapeDashStyle = DashStyle.Solid;
        float width = 5;
        bool IsPress = false;
        bool isFill = false;
        List<Shape> ListShape = new List<Shape>();
        List<Shape> listShapeSelected = new List<Shape>();

        // Handle Moving object
        PointF PreviousPoint = Point.Empty;
        Shape SelectedShape; //save shape when handle moving
        bool Moving = false;

        //handle enum
        DrawingMode mode;
        Keys keyListen;


        /// <summary>
        /// Handle enum with clicking event
        private void lineBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.line;
        }
        private void recBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.rec;
        }
        private void solidCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.isFill = solidCheck.Checked;
        }
        private void moveBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.move;
            this.IsPress = false;
        }
        private void groupBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.group;
            this.IsPress = false;
        }

        /// <summary>
        /// Painting Handle Event
        private void PaintingBox_MouseDown(object sender, MouseEventArgs e)
        {
            IsPress = true;

            switch (this.mode)
            {
                case DrawingMode.line:
                    Line myLine = new Line(e.Location, e.Location, width, myColor, ShapeDashStyle);
                    ListShape.Add(myLine);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.rec:
                    Rec myRec = new Rec(e.Location, e.Location, width, myColor, ShapeDashStyle, isFill);
                    ListShape.Add(myRec);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.move:
                    foreach (Shape myShape in ListShape)
                    {
                        IsPress = false;
                        if (myShape.IsHit(e.Location))
                        {
                            //press control key to choose more than one shape
                            if (this.keyListen == Keys.ControlKey)
                            {

                                //draw outline for each shape in shapes selected
                                if (!myShape.isShowOutline)
                                {
                                    listShapeSelected.Add(myShape);
                                    myShape.isShowOutline = true;
                                }
                                else
                                {
                                    listShapeSelected.Remove(myShape);
                                    myShape.isShowOutline = false;
                                }
                                this.PaintingBox.Invalidate();
                            }
                            SelectedShape = myShape;
                            PreviousPoint = e.Location;
                            Moving = true;
                        }
                    }
                    break;
                case DrawingMode.group:
                    //handle when we choose to group objects
                    foreach (Shape myShape in ListShape)
                    {

                        IsPress = false; //turn off so as to prevent mouse move action
                        if (myShape.IsHit(e.Location))
                        {
                            //press control key to choose more than one shape
                            if (this.keyListen == Keys.ControlKey)
                            {

                                //draw outline for each shape in shapes selected
                                if (!myShape.isShowOutline)
                                {
                                    listShapeSelected.Add(myShape);
                                    myShape.isShowOutline = true;
                                }
                                else
                                {
                                    listShapeSelected.Remove(myShape);
                                    myShape.isShowOutline = false;
                                }
                                this.PaintingBox.Invalidate();
                            }

                        }
                    }
                    break;
                default:
                    break;
            }

        }
        private void PaintingBox_MouseMove(object sender, MouseEventArgs e)
        {
            //When click to object and in moving mode 
            if (Moving && mode == DrawingMode.move)
            {
                if (SelectedShape != null)
                {
                    var d = new PointF(e.X - PreviousPoint.X, e.Y - PreviousPoint.Y);
                    SelectedShape.Move(d);
                    PreviousPoint = e.Location;
                    PaintingBox.Invalidate();
                }
            }
            //when out of moving mode, dragging shape is on
            else if (IsPress)
            {
                ListShape[ListShape.Count - 1].endPoint = e.Location;
                PaintingBox.Invalidate();
            }

        }
        private void PaintingBox_MouseUp(object sender, MouseEventArgs e)
        {
            //reset variable
            IsPress = false;
            Moving = false;
            Console.WriteLine(ListShape[ListShape.Count - 1].startPoint.ToString() + ListShape[ListShape.Count - 1].endPoint.ToString());
            PaintingBox.Invalidate();
        }

        //handle draw outline for shape with specific case
        public void HandleDrawShapeOutline(Shape shape, Graphics gp)
        {
            //Draw dash line at border (except line)
            if (!(shape is Line))
                ShapeOutline.DrawOutlineSelected(gp,
                    shape.startPoint, shape.endPoint);

            // Draw a circle as point for shape 
            if (shape is Line)
            {
                ShapeOutline.DrawSelectedPoint(gp,
                    shape.startPoint, shape.endPoint);
            }

            else if (shape is Rec)
                ShapeOutline.DrawSelectedPoint(gp,
                    shape.startPoint, shape.endPoint);
        }

        private void PaintingBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (var shape in ListShape)
            {
                shape.Draw(e.Graphics);

                //handle if bool showoueline is active
                if (shape.isShowOutline)
                {
                    this.HandleDrawShapeOutline(shape, e.Graphics);
                }

                //When moving
                if (this.Moving)
                {
                    this.HandleDrawShapeOutline(this.SelectedShape, e.Graphics);
                }
            }
        }

        private void dashCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dashCheck.Checked)
                this.ShapeDashStyle = DashStyle.Dash;
            else
                this.ShapeDashStyle = DashStyle.Solid;
        }

        //handle key event
        private void PaintingApp_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    this.keyListen = Keys.ControlKey;
                    //Console.WriteLine("click control");
                    break;
            }
        }

        private void PaintingApp_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    //reset list shape and outline properties
                    if (this.mode == DrawingMode.move || this.mode == DrawingMode.group)
                    {
                        this.keyListen = Keys.None;
                        foreach (var item in listShapeSelected) item.isShowOutline = false;
                        this.listShapeSelected.Clear();
                    }

                    if (this.mode == DrawingMode.group)
                    {

                    }
                    break;
            }
        }

        
    }
}