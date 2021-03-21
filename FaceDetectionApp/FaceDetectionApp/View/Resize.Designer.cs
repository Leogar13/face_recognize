namespace FaceDetectionApp.View
{
    partial class Resize
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
            this.btnText = new FaceDetectionApp.NeonButton();
            this.picText = new System.Windows.Forms.PictureBox();
            this.neonButton2 = new FaceDetectionApp.NeonButton();
            this.neonButton3 = new FaceDetectionApp.NeonButton();
            this.neonButton4 = new FaceDetectionApp.NeonButton();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).BeginInit();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.BorderColor = System.Drawing.Color.Green;
            this.btnText.BorderRadius = 30;
            this.btnText.Bordersizing = 1;
            this.btnText.GradientCenter = System.Drawing.Color.LightGreen;
            this.btnText.GradientRound = System.Drawing.Color.Black;
            this.btnText.Location = new System.Drawing.Point(21, 21);
            this.btnText.Name = "btnText";
            this.btnText.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnText.OnHoverButtonColor = System.Drawing.Color.Red;
            this.btnText.OnHoverTextColor = System.Drawing.Color.Blue;
            this.btnText.PercentileCenterColor = 0F;
            this.btnText.Size = new System.Drawing.Size(75, 41);
            this.btnText.TabIndex = 2;
            this.btnText.Text = "Open";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // picText
            // 
            this.picText.Location = new System.Drawing.Point(234, 0);
            this.picText.Name = "picText";
            this.picText.Size = new System.Drawing.Size(426, 364);
            this.picText.TabIndex = 0;
            this.picText.TabStop = false;
            // 
            // neonButton2
            // 
            this.neonButton2.BorderColor = System.Drawing.Color.Green;
            this.neonButton2.BorderRadius = 30;
            this.neonButton2.Bordersizing = 1;
            this.neonButton2.GradientCenter = System.Drawing.Color.LightGreen;
            this.neonButton2.GradientRound = System.Drawing.Color.Black;
            this.neonButton2.Location = new System.Drawing.Point(116, 21);
            this.neonButton2.Name = "neonButton2";
            this.neonButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.neonButton2.OnHoverButtonColor = System.Drawing.Color.Red;
            this.neonButton2.OnHoverTextColor = System.Drawing.Color.Blue;
            this.neonButton2.PercentileCenterColor = 0F;
            this.neonButton2.Size = new System.Drawing.Size(75, 41);
            this.neonButton2.TabIndex = 3;
            this.neonButton2.Text = "neonButton2";
            this.neonButton2.UseVisualStyleBackColor = true;
            // 
            // neonButton3
            // 
            this.neonButton3.BorderColor = System.Drawing.Color.Green;
            this.neonButton3.BorderRadius = 30;
            this.neonButton3.Bordersizing = 1;
            this.neonButton3.GradientCenter = System.Drawing.Color.LightGreen;
            this.neonButton3.GradientRound = System.Drawing.Color.Black;
            this.neonButton3.Location = new System.Drawing.Point(21, 78);
            this.neonButton3.Name = "neonButton3";
            this.neonButton3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.neonButton3.OnHoverButtonColor = System.Drawing.Color.Red;
            this.neonButton3.OnHoverTextColor = System.Drawing.Color.Blue;
            this.neonButton3.PercentileCenterColor = 0F;
            this.neonButton3.Size = new System.Drawing.Size(75, 41);
            this.neonButton3.TabIndex = 4;
            this.neonButton3.Text = "neonButton3";
            this.neonButton3.UseVisualStyleBackColor = true;
            // 
            // neonButton4
            // 
            this.neonButton4.BorderColor = System.Drawing.Color.Green;
            this.neonButton4.BorderRadius = 30;
            this.neonButton4.Bordersizing = 1;
            this.neonButton4.GradientCenter = System.Drawing.Color.LightGreen;
            this.neonButton4.GradientRound = System.Drawing.Color.Black;
            this.neonButton4.Location = new System.Drawing.Point(116, 78);
            this.neonButton4.Name = "neonButton4";
            this.neonButton4.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.neonButton4.OnHoverButtonColor = System.Drawing.Color.Red;
            this.neonButton4.OnHoverTextColor = System.Drawing.Color.Blue;
            this.neonButton4.PercentileCenterColor = 0F;
            this.neonButton4.Size = new System.Drawing.Size(75, 41);
            this.neonButton4.TabIndex = 5;
            this.neonButton4.Text = "neonButton4";
            this.neonButton4.UseVisualStyleBackColor = true;
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 366);
            this.Controls.Add(this.neonButton4);
            this.Controls.Add(this.neonButton3);
            this.Controls.Add(this.neonButton2);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.picText);
            this.Name = "Text";
            this.Text = "Text";
            ((System.ComponentModel.ISupportInitialize)(this.picText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picText;
        private NeonButton btnText;
        private NeonButton neonButton2;
        private NeonButton neonButton3;
        private NeonButton neonButton4;
    }
}