namespace MIDTERM_WINFORM_PAINT
{
    partial class PaintingApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintingApp));
            this.solidCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ungroupBtn = new System.Windows.Forms.Button();
            this.groupBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.polygonBtn = new System.Windows.Forms.Button();
            this.ArcBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.recBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.borderColorBtn = new System.Windows.Forms.Button();
            this.shapeColorBtn = new System.Windows.Forms.Button();
            this.DashStyleList = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZoomOutBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.PaintingBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // solidCheck
            // 
            this.solidCheck.AutoSize = true;
            this.solidCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.solidCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solidCheck.Location = new System.Drawing.Point(54, 30);
            this.solidCheck.Name = "solidCheck";
            this.solidCheck.Size = new System.Drawing.Size(66, 23);
            this.solidCheck.TabIndex = 2;
            this.solidCheck.Text = "Solid:";
            this.solidCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.solidCheck.UseVisualStyleBackColor = true;
            this.solidCheck.CheckedChanged += new System.EventHandler(this.solidCheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ungroupBtn);
            this.panel1.Controls.Add(this.groupBtn);
            this.panel1.Controls.Add(this.SelectBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Location = new System.Drawing.Point(8, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 104);
            this.panel1.TabIndex = 4;
            // 
            // ungroupBtn
            // 
            this.ungroupBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.Ungroup;
            this.ungroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ungroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ungroupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ungroupBtn.FlatAppearance.BorderSize = 2;
            this.ungroupBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ungroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ungroupBtn.Location = new System.Drawing.Point(9, 56);
            this.ungroupBtn.Name = "ungroupBtn";
            this.ungroupBtn.Size = new System.Drawing.Size(36, 39);
            this.ungroupBtn.TabIndex = 0;
            this.ungroupBtn.UseVisualStyleBackColor = true;
            this.ungroupBtn.Click += new System.EventHandler(this.ungroupBtn_Click);
            // 
            // groupBtn
            // 
            this.groupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBtn.BackgroundImage")));
            this.groupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.groupBtn.FlatAppearance.BorderSize = 2;
            this.groupBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.groupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBtn.Location = new System.Drawing.Point(51, 56);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(36, 39);
            this.groupBtn.TabIndex = 0;
            this.groupBtn.UseVisualStyleBackColor = true;
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectBtn.BackgroundImage")));
            this.SelectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SelectBtn.FlatAppearance.BorderSize = 2;
            this.SelectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectBtn.Location = new System.Drawing.Point(9, 9);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(36, 39);
            this.SelectBtn.TabIndex = 0;
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearBtn.BackgroundImage")));
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatAppearance.BorderSize = 2;
            this.clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(51, 9);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(36, 39);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.polygonBtn);
            this.panel2.Controls.Add(this.ArcBtn);
            this.panel2.Controls.Add(this.CircleBtn);
            this.panel2.Controls.Add(this.ellipseBtn);
            this.panel2.Controls.Add(this.recBtn);
            this.panel2.Controls.Add(this.lineBtn);
            this.panel2.Location = new System.Drawing.Point(118, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 102);
            this.panel2.TabIndex = 5;
            // 
            // polygonBtn
            // 
            this.polygonBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.polygon;
            this.polygonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.polygonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polygonBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.polygonBtn.FlatAppearance.BorderSize = 2;
            this.polygonBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.polygonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polygonBtn.Location = new System.Drawing.Point(49, 8);
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.Size = new System.Drawing.Size(36, 39);
            this.polygonBtn.TabIndex = 0;
            this.polygonBtn.UseVisualStyleBackColor = true;
            this.polygonBtn.Click += new System.EventHandler(this.polygonBtn_Click);
            // 
            // ArcBtn
            // 
            this.ArcBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.Arc;
            this.ArcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ArcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArcBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ArcBtn.FlatAppearance.BorderSize = 2;
            this.ArcBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ArcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArcBtn.Location = new System.Drawing.Point(91, 8);
            this.ArcBtn.Name = "ArcBtn";
            this.ArcBtn.Size = new System.Drawing.Size(36, 39);
            this.ArcBtn.TabIndex = 0;
            this.ArcBtn.UseVisualStyleBackColor = true;
            this.ArcBtn.Click += new System.EventHandler(this.ArcBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.Circle;
            this.CircleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CircleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CircleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CircleBtn.FlatAppearance.BorderSize = 2;
            this.CircleBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.CircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CircleBtn.Location = new System.Drawing.Point(91, 55);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(36, 39);
            this.CircleBtn.TabIndex = 0;
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.Ellipse;
            this.ellipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ellipseBtn.FlatAppearance.BorderSize = 2;
            this.ellipseBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ellipseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseBtn.Location = new System.Drawing.Point(49, 55);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(36, 39);
            this.ellipseBtn.TabIndex = 0;
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // recBtn
            // 
            this.recBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.Rec;
            this.recBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.recBtn.FlatAppearance.BorderSize = 2;
            this.recBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.recBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recBtn.Location = new System.Drawing.Point(7, 55);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(36, 39);
            this.recBtn.TabIndex = 0;
            this.recBtn.UseVisualStyleBackColor = true;
            this.recBtn.Click += new System.EventHandler(this.recBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.Line;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.lineBtn.FlatAppearance.BorderSize = 2;
            this.lineBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.Location = new System.Drawing.Point(7, 8);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(36, 39);
            this.lineBtn.TabIndex = 0;
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // borderColorBtn
            // 
            this.borderColorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.borderColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.borderColorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderColorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.borderColorBtn.FlatAppearance.BorderSize = 2;
            this.borderColorBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.borderColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderColorBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.borderColorBtn.Location = new System.Drawing.Point(135, 55);
            this.borderColorBtn.Name = "borderColorBtn";
            this.borderColorBtn.Size = new System.Drawing.Size(32, 34);
            this.borderColorBtn.TabIndex = 0;
            this.borderColorBtn.UseVisualStyleBackColor = false;
            this.borderColorBtn.Click += new System.EventHandler(this.borderColorBtn_Click);
            // 
            // shapeColorBtn
            // 
            this.shapeColorBtn.BackColor = System.Drawing.Color.Lime;
            this.shapeColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shapeColorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapeColorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.shapeColorBtn.FlatAppearance.BorderSize = 2;
            this.shapeColorBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.shapeColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapeColorBtn.Location = new System.Drawing.Point(157, 64);
            this.shapeColorBtn.Name = "shapeColorBtn";
            this.shapeColorBtn.Size = new System.Drawing.Size(32, 34);
            this.shapeColorBtn.TabIndex = 0;
            this.shapeColorBtn.UseVisualStyleBackColor = false;
            this.shapeColorBtn.Click += new System.EventHandler(this.shapeColorBtn_Click);
            // 
            // DashStyleList
            // 
            this.DashStyleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashStyleList.FormattingEnabled = true;
            this.DashStyleList.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash dot",
            "Dash dot dot"});
            this.DashStyleList.Location = new System.Drawing.Point(135, 8);
            this.DashStyleList.Name = "DashStyleList";
            this.DashStyleList.Size = new System.Drawing.Size(99, 21);
            this.DashStyleList.TabIndex = 6;
            this.DashStyleList.Text = "Dash Style";
            this.DashStyleList.SelectedIndexChanged += new System.EventHandler(this.DashStyleList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.DashStyleList);
            this.panel3.Controls.Add(this.ZoomOutBtn);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.borderColorBtn);
            this.panel3.Controls.Add(this.shapeColorBtn);
            this.panel3.Controls.Add(this.solidCheck);
            this.panel3.Location = new System.Drawing.Point(307, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 102);
            this.panel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(54, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Set Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(54, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dash style:";
            // 
            // ZoomOutBtn
            // 
            this.ZoomOutBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.ZoomOut;
            this.ZoomOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ZoomOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZoomOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ZoomOutBtn.FlatAppearance.BorderSize = 2;
            this.ZoomOutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ZoomOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomOutBtn.Location = new System.Drawing.Point(12, 7);
            this.ZoomOutBtn.Name = "ZoomOutBtn";
            this.ZoomOutBtn.Size = new System.Drawing.Size(36, 39);
            this.ZoomOutBtn.TabIndex = 0;
            this.ZoomOutBtn.UseVisualStyleBackColor = true;
            this.ZoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.ZoomIn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 39);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ZoomInBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOHO PAINTING APPLICATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tools";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(164, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shapes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(410, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adjust";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.appicon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.Close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(917, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(36, 39);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // PaintingBox
            // 
            this.PaintingBox.BackColor = System.Drawing.Color.White;
            this.PaintingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaintingBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintingBox.ErrorImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.cat;
            this.PaintingBox.InitialImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.cat;
            this.PaintingBox.Location = new System.Drawing.Point(8, 175);
            this.PaintingBox.Name = "PaintingBox";
            this.PaintingBox.Size = new System.Drawing.Size(936, 430);
            this.PaintingBox.TabIndex = 1;
            this.PaintingBox.TabStop = false;
            this.PaintingBox.WaitOnLoad = true;
            this.PaintingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintingBox_Paint);
            this.PaintingBox.DoubleClick += new System.EventHandler(this.PaintingBox_DoubleClick);
            this.PaintingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseDown);
            this.PaintingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseMove);
            this.PaintingBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseUp);
            // 
            // PaintingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(956, 617);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PaintingBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PaintingApp";
            this.Text = "Painting App";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PaintingApp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaintingApp_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaintingApp_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.PictureBox PaintingBox;
        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.CheckBox solidCheck;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button groupBtn;
        private System.Windows.Forms.Button ungroupBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button polygonBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button ZoomOutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button borderColorBtn;
        private System.Windows.Forms.Button shapeColorBtn;
        private System.Windows.Forms.ComboBox DashStyleList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ArcBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CircleBtn;
    }
}

