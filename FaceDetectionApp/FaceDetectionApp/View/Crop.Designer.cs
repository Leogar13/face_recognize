namespace FaceDetectionApp.View
{
    partial class Crop
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnSave = new FaceDetectionApp.NeonButton();
            this.btnExit = new FaceDetectionApp.NeonButton();
            this.lblmodifiedSize = new System.Windows.Forms.Label();
            this.lbloriginalSize = new System.Windows.Forms.Label();
            this.btnOpen = new FaceDetectionApp.NeonButton();
            this.picCrop2 = new System.Windows.Forms.PictureBox();
            this.picCrop1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrop1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnExit);
            this.splitContainer1.Panel1.Controls.Add(this.lblmodifiedSize);
            this.splitContainer1.Panel1.Controls.Add(this.lbloriginalSize);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.picCrop2);
            this.splitContainer1.Panel2.Controls.Add(this.picCrop1);
            this.splitContainer1.Size = new System.Drawing.Size(701, 374);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save:";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(15, 331);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(100, 20);
            this.txtSave.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.BorderColor = System.Drawing.Color.Green;
            this.btnSave.BorderRadius = 30;
            this.btnSave.Bordersizing = 1;
            this.btnSave.GradientCenter = System.Drawing.Color.LightGreen;
            this.btnSave.GradientRound = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(15, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.Aqua;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Blue;
            this.btnSave.PercentileCenterColor = 0F;
            this.btnSave.Size = new System.Drawing.Size(100, 49);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.BorderColor = System.Drawing.Color.Green;
            this.btnExit.BorderRadius = 30;
            this.btnExit.Bordersizing = 1;
            this.btnExit.GradientCenter = System.Drawing.Color.LightGreen;
            this.btnExit.GradientRound = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(15, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.Aqua;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Blue;
            this.btnExit.PercentileCenterColor = 0F;
            this.btnExit.Size = new System.Drawing.Size(100, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblmodifiedSize
            // 
            this.lblmodifiedSize.AutoSize = true;
            this.lblmodifiedSize.Location = new System.Drawing.Point(107, 334);
            this.lblmodifiedSize.Name = "lblmodifiedSize";
            this.lblmodifiedSize.Size = new System.Drawing.Size(0, 13);
            this.lblmodifiedSize.TabIndex = 4;
            // 
            // lbloriginalSize
            // 
            this.lbloriginalSize.AutoSize = true;
            this.lbloriginalSize.Location = new System.Drawing.Point(107, 305);
            this.lbloriginalSize.Name = "lbloriginalSize";
            this.lbloriginalSize.Size = new System.Drawing.Size(0, 13);
            this.lbloriginalSize.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpen.BorderColor = System.Drawing.Color.Green;
            this.btnOpen.BorderRadius = 30;
            this.btnOpen.Bordersizing = 1;
            this.btnOpen.GradientCenter = System.Drawing.Color.LightGreen;
            this.btnOpen.GradientRound = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(15, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnOpen.OnHoverButtonColor = System.Drawing.Color.Aquamarine;
            this.btnOpen.OnHoverTextColor = System.Drawing.Color.Blue;
            this.btnOpen.PercentileCenterColor = 0F;
            this.btnOpen.Size = new System.Drawing.Size(100, 49);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picCrop2
            // 
            this.picCrop2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCrop2.Location = new System.Drawing.Point(296, 3);
            this.picCrop2.Name = "picCrop2";
            this.picCrop2.Size = new System.Drawing.Size(245, 368);
            this.picCrop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCrop2.TabIndex = 1;
            this.picCrop2.TabStop = false;
            // 
            // picCrop1
            // 
            this.picCrop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCrop1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCrop1.Location = new System.Drawing.Point(3, 3);
            this.picCrop1.Name = "picCrop1";
            this.picCrop1.Size = new System.Drawing.Size(287, 371);
            this.picCrop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCrop1.TabIndex = 0;
            this.picCrop1.TabStop = false;
            // 
            // Crop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 374);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Crop";
            this.Text = "Cropping";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCrop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrop1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private NeonButton btnOpen;
        private System.Windows.Forms.PictureBox picCrop1;
        private System.Windows.Forms.Label lblmodifiedSize;
        private System.Windows.Forms.Label lbloriginalSize;
        private NeonButton btnExit;
        private NeonButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.PictureBox picCrop2;
    }
}