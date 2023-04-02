using System;
using System.Collections.Generic;
using System.Data;
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
        Shape SelectedShape = null; //save shape when handle moving
        bool Moving = false;

        //handle enum
        DrawingMode mode = DrawingMode.line;
        Keys keyListen;
        DrawingState state = DrawingState.none;


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
        private void ungroupBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.ungroup;
        }
        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.ellipse;
        }
        private void polygonBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.polygon;
        }
        //------------------------------------------------------------

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
                case DrawingMode.ellipse:
                    Ellipse myEllipse = new Ellipse(e.Location, e.Location, width, myColor, ShapeDashStyle, isFill);
                    ListShape.Add(myEllipse);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.polygon:
                    this.IsPress = false;

                    //if not drawing polygon then create a new one
                    if (this.state != DrawingState.isDrawingPolygon)
                    {
                        Polygon myPolygon = new Polygon(e.Location, e.Location, width, myColor, ShapeDashStyle, isFill);
                        ListShape.Add(myPolygon);
                        PaintingBox.Invalidate();
                        this.state = DrawingState.isDrawingPolygon;
                    }
                    //if is drawing polygon then add a new vertice when mouse down
                    //kiem tra lai primitive or reference
                    else
                    {
                        
                        Polygon myOldPolygon = ListShape[ListShape.Count - 1] as Polygon;

                        myOldPolygon.Vertices.Add(e.Location);
                    }
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

                            //-----------optimize-----------
                            SelectedShape = myShape;
                            PreviousPoint = e.Location;
                            Moving = true;
                        }
                    }
                    break;
                case DrawingMode.group:
                    //this part can be optimize by using same case with moving
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
                case DrawingMode.ungroup:
                    //handle when we choose to group objects
                    IsPress = false; //turn off so as to prevent mouse move action

                    //dang xu ly ungroup, tam thoi lam 

                    /*this.SelectedShape = null;
                    foreach (Shape myShape in ListShape)
                    {
                        //when hit the group
                        if (myShape is GroupOfShape groupOfShape && myShape.IsHit(e.Location))
                        {
                            //press control key to choose more than one shape
                            if (this.keyListen == Keys.ControlKey)
                            {

                                //draw outline for each shape in shapes selected
                                //toggle ouline bool
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

                                //draw outline after set outline bool
                                this.PaintingBox.Invalidate();
                            }
                            else 
                            {
                                //this.SelectedShape = myShape;
                                DialogResult result = MessageBox.Show("Do you want to ungroup those shapes?", "Ungroup", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                    groupOfShape.Ungroup(ref this.ListShape);
                            
                            }


                        }
                    }*/
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
            else if (this.state == DrawingState.isDrawingPolygon)
            {

                Polygon myOldPolygon = ListShape[ListShape.Count - 1] as Polygon;
                myOldPolygon.Vertices[myOldPolygon.Vertices.Count - 1] = e.Location;
                PaintingBox.Invalidate();

                myOldPolygon = null;
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

        /// <summary>
        /// Support Function
        //handle draw outline for shape with specific case
        public void HandleDrawShapeOutline(Shape shape, Graphics gp)
        {
            //Draw dash line at border (except line)
            if (!(shape is Line))
                ShapeOutline.DrawOutlineSelected(gp,
                    shape.startPoint, shape.endPoint);

            // Draw a circle as point for shape 
            if (shape is Polygon)
            {
                //case polygon draw more circle than other shape

                //ShapeOutline.DrawSelectedPoint(gp,
                //    shape.startPoint, shape.endPoint);
            }
            else ShapeOutline.DrawSelectedPoint(gp, shape.startPoint, shape.endPoint);
                
        }

        private void PaintingBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (var shape in ListShape)
            {
                shape.Draw(e.Graphics);

                //handle if bool showoueline is active
                if (shape.isShowOutline)
                    this.HandleDrawShapeOutline(shape, e.Graphics);

                //When moving
                if (this.Moving)
                    this.HandleDrawShapeOutline(this.SelectedShape, e.Graphics);
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
                    break;
            }
        }

        private void PaintingApp_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    

                    if (this.mode == DrawingMode.group)
                    {
                        DialogResult result = DialogResult.None;
                        if (this.listShapeSelected.Count > 1)
                            result =  MessageBox.Show("Do you want to group those shapes?", "Group", MessageBoxButtons.YesNo);
                        
                        if (result == DialogResult.Yes)
                        {
                            GroupOfShape groupOfShape = new GroupOfShape(this.listShapeSelected);
                            
                            //add group shape to list shape and remove single component
                            ListShape.Add(groupOfShape);
                            groupOfShape.delSingleComponentFromMain(ref this.ListShape);

                            //draw all comopoent in list shape again
                            this.PaintingBox.Invalidate();
                            
                        }
                    }

                    foreach (var item in ListShape) Console.WriteLine(item.ToString());

                    //reset list shape and outline properties
                    //---
                    if (this.mode == DrawingMode.move || this.mode == DrawingMode.group)
                    {
                        this.keyListen = Keys.None;
                        foreach (var item in listShapeSelected) item.isShowOutline = false;
                        this.listShapeSelected.Clear();
                    }
                    break;
            }
        }

        
    }
}
