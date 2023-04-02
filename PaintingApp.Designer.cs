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
            this.lineBtn = new System.Windows.Forms.Button();
            this.PaintingBox = new System.Windows.Forms.PictureBox();
            this.recBtn = new System.Windows.Forms.Button();
            this.solidCheck = new System.Windows.Forms.CheckBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.dashCheck = new System.Windows.Forms.CheckBox();
            this.groupBtn = new System.Windows.Forms.Button();
            this.ungroupBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.polygonBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(198, 12);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(75, 23);
            this.lineBtn.TabIndex = 0;
            this.lineBtn.Text = "line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // PaintingBox
            // 
            this.PaintingBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaintingBox.Location = new System.Drawing.Point(12, 92);
            this.PaintingBox.Name = "PaintingBox";
            this.PaintingBox.Size = new System.Drawing.Size(776, 346);
            this.PaintingBox.TabIndex = 1;
            this.PaintingBox.TabStop = false;
            this.PaintingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintingBox_Paint);
            this.PaintingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseDown);
            this.PaintingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseMove);
            this.PaintingBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintingBox_MouseUp);
            // 
            // recBtn
            // 
            this.recBtn.Location = new System.Drawing.Point(198, 41);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(75, 23);
            this.recBtn.TabIndex = 0;
            this.recBtn.Text = "rectangle";
            this.recBtn.UseVisualStyleBackColor = true;
            this.recBtn.Click += new System.EventHandler(this.recBtn_Click);
            // 
            // solidCheck
            // 
            this.solidCheck.AutoSize = true;
            this.solidCheck.Location = new System.Drawing.Point(551, 45);
            this.solidCheck.Name = "solidCheck";
            this.solidCheck.Size = new System.Drawing.Size(49, 17);
            this.solidCheck.TabIndex = 2;
            this.solidCheck.Text = "Solid";
            this.solidCheck.UseVisualStyleBackColor = true;
            this.solidCheck.CheckedChanged += new System.EventHandler(this.solidCheck_CheckedChanged);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(98, 12);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectBtn.TabIndex = 0;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // dashCheck
            // 
            this.dashCheck.AutoSize = true;
            this.dashCheck.Location = new System.Drawing.Point(551, 18);
            this.dashCheck.Name = "dashCheck";
            this.dashCheck.Size = new System.Drawing.Size(51, 17);
            this.dashCheck.TabIndex = 3;
            this.dashCheck.Text = "Dash";
            this.dashCheck.UseVisualStyleBackColor = true;
            this.dashCheck.CheckedChanged += new System.EventHandler(this.dashCheck_CheckedChanged);
            // 
            // groupBtn
            // 
            this.groupBtn.Location = new System.Drawing.Point(98, 41);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(75, 23);
            this.groupBtn.TabIndex = 0;
            this.groupBtn.Text = "GROUP";
            this.groupBtn.UseVisualStyleBackColor = true;
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // ungroupBtn
            // 
            this.ungroupBtn.Location = new System.Drawing.Point(17, 41);
            this.ungroupBtn.Name = "ungroupBtn";
            this.ungroupBtn.Size = new System.Drawing.Size(75, 23);
            this.ungroupBtn.TabIndex = 0;
            this.ungroupBtn.Text = "Ungroup";
            this.ungroupBtn.UseVisualStyleBackColor = true;
            this.ungroupBtn.Click += new System.EventHandler(this.ungroupBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Location = new System.Drawing.Point(279, 41);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(75, 23);
            this.ellipseBtn.TabIndex = 0;
            this.ellipseBtn.Text = "ellipse";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // polygonBtn
            // 
            this.polygonBtn.Location = new System.Drawing.Point(279, 12);
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.Size = new System.Drawing.Size(75, 23);
            this.polygonBtn.TabIndex = 0;
            this.polygonBtn.Text = "polygon";
            this.polygonBtn.UseVisualStyleBackColor = true;
            this.polygonBtn.Click += new System.EventHandler(this.polygonBtn_Click);
            // 
            // PaintingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashCheck);
            this.Controls.Add(this.solidCheck);
            this.Controls.Add(this.PaintingBox);
            this.Controls.Add(this.ungroupBtn);
            this.Controls.Add(this.groupBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.polygonBtn);
            this.Controls.Add(this.ellipseBtn);
            this.Controls.Add(this.recBtn);
            this.Controls.Add(this.lineBtn);
            this.KeyPreview = true;
            this.Name = "PaintingApp";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaintingApp_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaintingApp_KeyUp);
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
    }
}

