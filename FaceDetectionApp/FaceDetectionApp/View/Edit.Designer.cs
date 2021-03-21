namespace FaceDetectionApp.View
{
    partial class Edit
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
            this.lable = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Btn_Exit = new FaceDetectionApp.RoundButton();
            this.Btn_Save = new FaceDetectionApp.RoundButton();
            this.Btn_Change = new FaceDetectionApp.RoundButton();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.picRotated = new System.Windows.Forms.PictureBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRotated)).BeginInit();
            this.SuspendLayout();
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lable.Location = new System.Drawing.Point(29, 29);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(36, 15);
            this.lable.TabIndex = 0;
            this.lable.Text = "Angle";
            this.lable.Click += new System.EventHandler(this.txtAngle_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar1.Location = new System.Drawing.Point(190, 29);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(413, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Exit.BorderColor = System.Drawing.Color.Green;
            this.Btn_Exit.BorderRadius = 30;
            this.Btn_Exit.Bordersizing = 1;
            this.Btn_Exit.Location = new System.Drawing.Point(12, 238);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.Btn_Exit.OnHoverButtonColor = System.Drawing.Color.Aqua;
            this.Btn_Exit.OnHoverTextColor = System.Drawing.Color.Blue;
            this.Btn_Exit.Size = new System.Drawing.Size(86, 38);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Save.BorderColor = System.Drawing.Color.Green;
            this.Btn_Save.BorderRadius = 30;
            this.Btn_Save.Bordersizing = 1;
            this.Btn_Save.Location = new System.Drawing.Point(12, 163);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.Btn_Save.OnHoverButtonColor = System.Drawing.Color.Aqua;
            this.Btn_Save.OnHoverTextColor = System.Drawing.Color.Blue;
            this.Btn_Save.Size = new System.Drawing.Size(86, 38);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save Image";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Change
            // 
            this.Btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Change.BorderColor = System.Drawing.Color.Green;
            this.Btn_Change.BorderRadius = 30;
            this.Btn_Change.Bordersizing = 1;
            this.Btn_Change.Location = new System.Drawing.Point(12, 83);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.Btn_Change.OnHoverButtonColor = System.Drawing.Color.Aqua;
            this.Btn_Change.OnHoverTextColor = System.Drawing.Color.Blue;
            this.Btn_Change.Size = new System.Drawing.Size(86, 38);
            this.Btn_Change.TabIndex = 2;
            this.Btn_Change.Text = "Open";
            this.Btn_Change.UseVisualStyleBackColor = false;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Change_Click);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(71, 26);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 0;
            // 
            // picRotated
            // 
            this.picRotated.BackColor = System.Drawing.Color.Teal;
            this.picRotated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRotated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRotated.Location = new System.Drawing.Point(119, 66);
            this.picRotated.Name = "picRotated";
            this.picRotated.Size = new System.Drawing.Size(507, 291);
            this.picRotated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRotated.TabIndex = 5;
            this.picRotated.TabStop = false;
            this.picRotated.Click += new System.EventHandler(this.picRotated_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(12, 303);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 6;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(638, 369);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.picRotated);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Change);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.trackBar1);
            this.Name = "Edit";
            this.Text = "Rotate ";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRotated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TrackBar trackBar1;
        private RoundButton Btn_Change;
        private RoundButton Btn_Save;
        private RoundButton Btn_Exit;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.PictureBox picRotated;
        private System.Windows.Forms.TextBox txtTen;
    }
}