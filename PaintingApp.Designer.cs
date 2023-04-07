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
            this.dashCheck = new System.Windows.Forms.CheckBox();
            this.ZoomOutBtn = new System.Windows.Forms.Button();
            this.ZoomInBtn = new System.Windows.Forms.Button();
            this.polygonBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.recBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ungroupBtn = new System.Windows.Forms.Button();
            this.groupBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PaintingBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // solidCheck
            // 
            this.solidCheck.AutoSize = true;
            this.solidCheck.Location = new System.Drawing.Point(735, 55);
            this.solidCheck.Margin = new System.Windows.Forms.Padding(4);
            this.solidCheck.Name = "solidCheck";
            this.solidCheck.Size = new System.Drawing.Size(60, 20);
            this.solidCheck.TabIndex = 2;
            this.solidCheck.Text = "Solid";
            this.solidCheck.UseVisualStyleBackColor = true;
            this.solidCheck.CheckedChanged += new System.EventHandler(this.solidCheck_CheckedChanged);
            // 
            // dashCheck
            // 
            this.dashCheck.AutoSize = true;
            this.dashCheck.Location = new System.Drawing.Point(735, 22);
            this.dashCheck.Margin = new System.Windows.Forms.Padding(4);
            this.dashCheck.Name = "dashCheck";
            this.dashCheck.Size = new System.Drawing.Size(61, 20);
            this.dashCheck.TabIndex = 3;
            this.dashCheck.Text = "Dash";
            this.dashCheck.UseVisualStyleBackColor = true;
            this.dashCheck.CheckedChanged += new System.EventHandler(this.dashCheck_CheckedChanged);
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
            this.ZoomOutBtn.Location = new System.Drawing.Point(666, 15);
            this.ZoomOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomOutBtn.Name = "ZoomOutBtn";
            this.ZoomOutBtn.Size = new System.Drawing.Size(48, 48);
            this.ZoomOutBtn.TabIndex = 0;
            this.ZoomOutBtn.UseVisualStyleBackColor = true;
            this.ZoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // ZoomInBtn
            // 
            this.ZoomInBtn.BackgroundImage = global::MIDTERM_WINFORM_PAINT.Properties.Resources.ZoomIn;
            this.ZoomInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ZoomInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZoomInBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ZoomInBtn.FlatAppearance.BorderSize = 2;
            this.ZoomInBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ZoomInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomInBtn.Location = new System.Drawing.Point(666, 71);
            this.ZoomInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomInBtn.Name = "ZoomInBtn";
            this.ZoomInBtn.Size = new System.Drawing.Size(48, 48);
            this.ZoomInBtn.TabIndex = 0;
            this.ZoomInBtn.UseVisualStyleBackColor = true;
            this.ZoomInBtn.Click += new System.EventHandler(this.ZoomInBtn_Click);
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
            this.polygonBtn.Location = new System.Drawing.Point(65, 10);
            this.polygonBtn.Margin = new System.Windows.Forms.Padding(4);
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.Size = new System.Drawing.Size(48, 48);
            this.polygonBtn.TabIndex = 0;
            this.polygonBtn.UseVisualStyleBackColor = true;
            this.polygonBtn.Click += new System.EventHandler(this.polygonBtn_Click);
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
            this.ellipseBtn.Location = new System.Drawing.Point(65, 68);
            this.ellipseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(48, 48);
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
            this.recBtn.Location = new System.Drawing.Point(9, 68);
            this.recBtn.Margin = new System.Windows.Forms.Padding(4);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(48, 48);
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
            this.lineBtn.Location = new System.Drawing.Point(9, 10);
            this.lineBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(48, 48);
            this.lineBtn.TabIndex = 0;
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ungroupBtn);
            this.panel1.Controls.Add(this.groupBtn);
            this.panel1.Controls.Add(this.SelectBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Location = new System.Drawing.Point(18, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
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
            this.ungroupBtn.Location = new System.Drawing.Point(12, 69);
            this.ungroupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ungroupBtn.Name = "ungroupBtn";
            this.ungroupBtn.Size = new System.Drawing.Size(48, 48);
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
            this.groupBtn.Location = new System.Drawing.Point(68, 69);
            this.groupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(48, 48);
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
            this.SelectBtn.Location = new System.Drawing.Point(12, 11);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(48, 48);
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
            this.clearBtn.Location = new System.Drawing.Point(68, 11);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(48, 48);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.polygonBtn);
            this.panel2.Controls.Add(this.ellipseBtn);
            this.panel2.Controls.Add(this.recBtn);
            this.panel2.Controls.Add(this.lineBtn);
            this.panel2.Location = new System.Drawing.Point(165, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 126);
            this.panel2.TabIndex = 5;
            // 
            // PaintingBox
            // 
            this.PaintingBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaintingBox.Location = new System.Drawing.Point(16, 148);
            this.PaintingBox.Margin = new System.Windows.Forms.Padding(4);
            this.PaintingBox.Name = "PaintingBox";
            this.PaintingBox.Size = new System.Drawing.Size(1246, 400);
            this.PaintingBox.TabIndex = 1;
            this.PaintingBox.TabStop = false;
            this.PaintingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintingBox_Paint);
            this.PaintingBox.DoubleClick += new System.EventHandler(this.PaintingBox_DoubleClick);
            this.PaintingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseDown);
            this.PaintingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseMove);
            this.PaintingBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseUp);
            // 
            // PaintingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashCheck);
            this.Controls.Add(this.solidCheck);
            this.Controls.Add(this.PaintingBox);
            this.Controls.Add(this.ZoomOutBtn);
            this.Controls.Add(this.ZoomInBtn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaintingApp";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaintingApp_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaintingApp_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox dashCheck;
        private System.Windows.Forms.Button groupBtn;
        private System.Windows.Forms.Button ungroupBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button polygonBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button ZoomInBtn;
        private System.Windows.Forms.Button ZoomOutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

