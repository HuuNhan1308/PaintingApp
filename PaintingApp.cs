using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;


// thiet ke chinh width, chinh dash style.


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
        private Color myColor = Color.Blue;
        private Color borderColor = Color.Blue;
        DashStyle ShapeDashStyle = DashStyle.Solid;
        float Width = 5;
        bool IsPress = false;
        bool isFill = false;
        List<Shape> ListShape = new List<Shape>();
        List<Shape> listShapeSelected = new List<Shape>();

        // Handle Moving object
        PointF PreviousPoint = Point.Empty;
        Shape SelectedShape = null; //save shape when handle moving
        bool Moving = false;
        bool isHitResizePoint = false;

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
            if (this.ListShape.Count == 0)
            {
                MessageBox.Show("Please draw something so as to use this function");
                return;
            }
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
        private void ArcBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.arc;
        }
        private void CircleBtn_Click(object sender, EventArgs e)
        {
            this.mode = DrawingMode.circle;
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
                    Line myLine = new Line(e.Location, e.Location, Width, myColor, ShapeDashStyle);
                    ListShape.Add(myLine);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.rec:
                    Rec myRec = new Rec(e.Location, e.Location, Width, myColor, ShapeDashStyle, isFill, borderColor);
                    ListShape.Add(myRec);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.ellipse:
                    Ellipse myEllipse = new Ellipse(e.Location, e.Location, Width, myColor, ShapeDashStyle, isFill, borderColor);
                    ListShape.Add(myEllipse);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.circle:
                    Circle myCircle = new Circle(e.Location, e.Location, Width, myColor, ShapeDashStyle, isFill, borderColor);
                    ListShape.Add(myCircle);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.polygon:
                    this.IsPress = false;

                    //if not drawing polygon then create a new one
                    if (this.state != DrawingState.isDrawingPolygon)
                    {
                        Polygon myPolygon = new Polygon(e.Location, e.Location, Width, myColor, ShapeDashStyle, isFill, borderColor);
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
                case DrawingMode.arc:
                    Arc myArc = new Arc(e.Location, e.Location, Width, myColor, ShapeDashStyle);
                    ListShape.Add(myArc);
                    PaintingBox.Invalidate();
                    break;
                case DrawingMode.move:  //move = select button
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
                            }
                            SelectedShape = myShape;
                            PreviousPoint = e.Location;
                            Moving = true;

                            this.PaintingBox.Invalidate();
                            //-----------optimize-----------

                        }
                        else
                        {
                            myShape.isShowOutline = false;
                            this.PaintingBox.Invalidate();
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

                    this.SelectedShape = null;
                    foreach (Shape myShape in ListShape)
                    {
                        //when hit the group
                        if (myShape is GroupOfShape groupOfShape && myShape.IsHit(e.Location))
                        {
                            //this.SelectedShape = myShape;
                            DialogResult result = MessageBox.Show("Do you want to ungroup those shapes?", "Ungroup", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                groupOfShape.Ungroup(ref this.ListShape);
                                //ListShape.Remove(groupOfShape);
                                break;
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
            //when out of moving mode, moving line of shape is on
            else if (IsPress)
            {
                ListShape[ListShape.Count - 1].EndPoint = e.Location;
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
            Console.WriteLine(ListShape[ListShape.Count - 1].StartPoint.ToString() + ListShape[ListShape.Count - 1].EndPoint.ToString());
            //PaintingBox.Invalidate();
        }

        /// <summary>
        /// Support Function
        //handle draw outline for shape with specific case
        public void HandleDrawShapeOutline(Shape shape, Graphics gp)
        {
            //Draw dash line at border (except line)
            if (shape is Polygon polygon)
                ShapeOutline.DrawOutlineSelected(gp, polygon.BorderStartPoint, polygon.BorderEndPoint);
            else if (!(shape is Line))
                ShapeOutline.DrawOutlineSelected(gp,
                    shape.StartPoint, shape.EndPoint);

            // Draw a circle as point for shape 
            if (shape is Polygon polygon1)
                ShapeOutline.DrawSelectedPoint(gp, polygon1.BorderStartPoint, polygon1.BorderEndPoint);
            //not pologon then draw a 
            else ShapeOutline.DrawSelectedPoint(gp, shape.StartPoint, shape.EndPoint);
                
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


        ///APP FUNCTION
        ///
        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.ListShape.Clear();
            this.PaintingBox.Invalidate();
        }
        private void PaintingApp_Load(object sender, EventArgs e)
        {
            this.myColor = this.shapeColorBtn.BackColor;
            this.borderColor = this.borderColorBtn.BackColor;
        }
        private void DashStyleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.DashStyleList.SelectedItem.ToString())
            {
                case "Solid":
                    this.ShapeDashStyle = DashStyle.Solid;
                    break;
                case "Dash":
                    this.ShapeDashStyle = DashStyle.Dash;
                    break;
                case "Dot":
                    this.ShapeDashStyle = DashStyle.Dot;
                    break;
                case "Dash dot":
                    this.ShapeDashStyle = DashStyle.DashDot;
                    break;
                case "Dash dot dot":
                    this.ShapeDashStyle = DashStyle.DashDotDot;
                    break;
                default:
                    this.ShapeDashStyle = DashStyle.Solid;
                    break;

            }
        }
        private void ZoomInBtn_Click(object sender, EventArgs e)
        {
            //case selectedShape is null;
            try
            {
                if (SelectedShape is null) throw new Exception("Select a shape to zoom");
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex.Message.ToString()}");
                return;
            }

            //zoom in ~20%
            SelectedShape.SizeUp();
            this.PaintingBox.Invalidate();
        }
        private void ZoomOutBtn_Click(object sender, EventArgs e)
        {
            //case selectedShape is null;
            try
            {
                if (SelectedShape is null) throw new Exception("Select a shape to zoom");
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex.Message.ToString()}");
                return;
            }

            //zoom in ~20%
            SelectedShape.SizeDown();
            this.PaintingBox.Invalidate();
        }
        private void borderColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                myColor = dlg.Color;
                borderColorBtn.BackColor = dlg.Color;
            }
        }
        private void shapeColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                myColor = dlg.Color;
                borderColorBtn.BackColor = dlg.Color;
            }
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
                    
                    //control up and group --> then group
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

        private void PaintingBox_DoubleClick(object sender, EventArgs e)
        {
            switch(this.state)
            {
                case DrawingState.isDrawingPolygon:
                    this.state = DrawingState.none;
                    break;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.PaintingBox.BackgroundImage == null)
                this.PaintingBox.BackgroundImage = Properties.Resources.cat;
            else this.PaintingBox.BackgroundImage = null;
        }

        
    }
}
