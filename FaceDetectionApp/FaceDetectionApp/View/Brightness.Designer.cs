namespace FaceDetectionApp.View
{
    partial class Brightness
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.DomainUpDownBright = new System.Windows.Forms.DomainUpDown();
            this.picBright = new System.Windows.Forms.PictureBox();
            this.btnOpen = new FaceDetectionApp.NeonButton();
            this.btnExit = new FaceDetectionApp.NeonButton();
            this.btnSave = new FaceDetectionApp.NeonButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBright)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(166, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // DomainUpDownBright
            // 
            this.DomainUpDownBright.Location = new System.Drawing.Point(12, 54);
            this.DomainUpDownBright.Name = "DomainUpDownBright";
            this.DomainUpDownBright.Size = new System.Drawing.Size(120, 20);
            this.DomainUpDownBright.TabIndex = 4;
            this.DomainUpDownBright.SelectedItemChanged += new System.EventHandler(this.btndomainUpDown1_SelectedItemChanged);
            // 
            // picBright
            // 
            this.picBright.BackColor = System.Drawing.Color.Teal;
            this.picBright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBright.Location = new System.Drawing.Point(173, 12);
            this.picBright.Name = "picBright";
            this.picBright.Size = new System.Drawing.Size(495, 310);
            this.picBright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBright.TabIndex = 5;
            this.picBright.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpen.BorderColor = System.Drawing.Color.Green;
            this.btnOpen.BorderRadius = 30;
            this.btnOpen.Bordersizing = 1;
            this.btnOpen.GradientCenter = System.Drawing.Color.LightGreen;
            this.btnOpen.GradientRound = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(23, 102);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpen.OnHoverButtonColor = System.Drawing.Color.Aquamarine;
            this.btnOpen.OnHoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnOpen.PercentileCenterColor = 0F;
            this.btnOpen.Size = new System.Drawing.Size(109, 50);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.BorderColor = System.Drawing.Color.Green;
            this.btnExit.BorderRadius = 30;
            this.btnExit.Bordersizing = 1;
            this.btnExit.GradientCenter = System.Drawing.Color.LightGreen;
            this.btnExit.GradientRound = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(23, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.Aquamarine;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.PercentileCenterColor = 0F;
            this.btnExit.Size = new System.Drawing.Size(109, 52);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.BorderColor = System.Drawing.Color.Green;
            this.btnSave.BorderRadius = 30;
            this.btnSave.Bordersizing = 1;
            this.btnSave.GradientCenter = System.Drawing.Color.LightGreen;
            this.btnSave.GradientRound = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(23, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.Aquamarine;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.PercentileCenterColor = 0F;
            this.btnSave.Size = new System.Drawing.Size(109, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Brightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(680, 334);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picBright);
            this.Controls.Add(this.DomainUpDownBright);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Name = "Brightness";
            this.Text = "Brightness";
            this.Load += new System.EventHandler(this.Brightness_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NeonButton btnSave;
        private NeonButton btnExit;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DomainUpDown DomainUpDownBright;
        private System.Windows.Forms.PictureBox picBright;
        private NeonButton btnOpen;
    }
}