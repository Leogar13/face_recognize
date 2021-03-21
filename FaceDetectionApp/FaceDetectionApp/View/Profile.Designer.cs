namespace FaceDetectionApp.View
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.EditBt = new FaceDetectionApp.RoundButton();
            this.GalleryButton = new FaceDetectionApp.RoundButton();
            this.FaceTrainedImage = new System.Windows.Forms.PictureBox();
            this.IntroduceOfFaceTrained = new System.Windows.Forms.Label();
            this.PersonalImage = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BirthdayText = new System.Windows.Forms.Label();
            this.GallerryButton = new FaceDetectionApp.RoundButton();
            this.EditButton = new FaceDetectionApp.RoundButton();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaceTrainedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftPanel.BackColor = System.Drawing.Color.Yellow;
            this.LeftPanel.Controls.Add(this.EditBt);
            this.LeftPanel.Controls.Add(this.GalleryButton);
            this.LeftPanel.Controls.Add(this.FaceTrainedImage);
            this.LeftPanel.Controls.Add(this.IntroduceOfFaceTrained);
            this.LeftPanel.Controls.Add(this.PersonalImage);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(347, 472);
            this.LeftPanel.TabIndex = 0;
            // 
            // EditBt
            // 
            this.EditBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditBt.BackColor = System.Drawing.Color.Lime;
            this.EditBt.BorderColor = System.Drawing.Color.Green;
            this.EditBt.BorderRadius = 30;
            this.EditBt.Bordersizing = 3;
            this.EditBt.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditBt.Location = new System.Drawing.Point(194, 414);
            this.EditBt.Name = "EditBt";
            this.EditBt.OnHoverBorderColor = System.Drawing.Color.Green;
            this.EditBt.OnHoverButtonColor = System.Drawing.Color.LimeGreen;
            this.EditBt.OnHoverTextColor = System.Drawing.Color.Black;
            this.EditBt.Size = new System.Drawing.Size(118, 45);
            this.EditBt.TabIndex = 4;
            this.EditBt.Text = "Edit";
            this.EditBt.UseVisualStyleBackColor = false;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // GalleryButton
            // 
            this.GalleryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GalleryButton.BackColor = System.Drawing.Color.Aqua;
            this.GalleryButton.BorderColor = System.Drawing.Color.Green;
            this.GalleryButton.BorderRadius = 30;
            this.GalleryButton.Bordersizing = 3;
            this.GalleryButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GalleryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GalleryButton.Location = new System.Drawing.Point(34, 414);
            this.GalleryButton.Name = "GalleryButton";
            this.GalleryButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.GalleryButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.GalleryButton.OnHoverTextColor = System.Drawing.Color.White;
            this.GalleryButton.Size = new System.Drawing.Size(118, 45);
            this.GalleryButton.TabIndex = 3;
            this.GalleryButton.Text = "Gallery";
            this.GalleryButton.UseVisualStyleBackColor = false;
            // 
            // FaceTrainedImage
            // 
            this.FaceTrainedImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FaceTrainedImage.Location = new System.Drawing.Point(121, 258);
            this.FaceTrainedImage.Name = "FaceTrainedImage";
            this.FaceTrainedImage.Size = new System.Drawing.Size(100, 100);
            this.FaceTrainedImage.TabIndex = 2;
            this.FaceTrainedImage.TabStop = false;
            // 
            // IntroduceOfFaceTrained
            // 
            this.IntroduceOfFaceTrained.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntroduceOfFaceTrained.AutoSize = true;
            this.IntroduceOfFaceTrained.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroduceOfFaceTrained.ForeColor = System.Drawing.Color.Black;
            this.IntroduceOfFaceTrained.Location = new System.Drawing.Point(118, 361);
            this.IntroduceOfFaceTrained.Name = "IntroduceOfFaceTrained";
            this.IntroduceOfFaceTrained.Size = new System.Drawing.Size(103, 24);
            this.IntroduceOfFaceTrained.TabIndex = 2;
            this.IntroduceOfFaceTrained.Text = "Face to Trained";
            // 
            // PersonalImage
            // 
            this.PersonalImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PersonalImage.BackColor = System.Drawing.Color.Transparent;
            this.PersonalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PersonalImage.Location = new System.Drawing.Point(12, 12);
            this.PersonalImage.Name = "PersonalImage";
            this.PersonalImage.Size = new System.Drawing.Size(320, 240);
            this.PersonalImage.TabIndex = 0;
            this.PersonalImage.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.NameLabel.Location = new System.Drawing.Point(429, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayLabel.ForeColor = System.Drawing.Color.Yellow;
            this.BirthdayLabel.Location = new System.Drawing.Point(429, 124);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(84, 22);
            this.BirthdayLabel.TabIndex = 1;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Yellow;
            this.DescriptionLabel.Location = new System.Drawing.Point(429, 175);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(107, 22);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.Color.Aqua;
            this.NameText.Location = new System.Drawing.Point(540, 35);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(0, 24);
            this.NameText.TabIndex = 2;
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionRichTextBox.BackColor = System.Drawing.Color.Black;
            this.DescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionRichTextBox.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DescriptionRichTextBox.ForeColor = System.Drawing.Color.Aqua;
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(433, 216);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.ReadOnly = true;
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(384, 256);
            this.DescriptionRichTextBox.TabIndex = 3;
            this.DescriptionRichTextBox.Text = "";
            // 
            // BirthdayText
            // 
            this.BirthdayText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayText.AutoSize = true;
            this.BirthdayText.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayText.ForeColor = System.Drawing.Color.Aqua;
            this.BirthdayText.Location = new System.Drawing.Point(540, 125);
            this.BirthdayText.Name = "BirthdayText";
            this.BirthdayText.Size = new System.Drawing.Size(0, 24);
            this.BirthdayText.TabIndex = 2;
            // 
            // GallerryButton
            // 
            this.GallerryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GallerryButton.BorderColor = System.Drawing.Color.Green;
            this.GallerryButton.BorderRadius = 30;
            this.GallerryButton.Bordersizing = 5;
            this.GallerryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GallerryButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GallerryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GallerryButton.Location = new System.Drawing.Point(12, 399);
            this.GallerryButton.Name = "GallerryButton";
            this.GallerryButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.GallerryButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.GallerryButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.GallerryButton.Size = new System.Drawing.Size(128, 55);
            this.GallerryButton.TabIndex = 1;
            this.GallerryButton.Text = "Gallery";
            this.GallerryButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Red;
            this.EditButton.BorderColor = System.Drawing.Color.Green;
            this.EditButton.BorderRadius = 30;
            this.EditButton.Bordersizing = 5;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(204, 399);
            this.EditButton.Name = "EditButton";
            this.EditButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.EditButton.OnHoverButtonColor = System.Drawing.Color.Maroon;
            this.EditButton.OnHoverTextColor = System.Drawing.Color.White;
            this.EditButton.Size = new System.Drawing.Size(128, 55);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit Face";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.UserNameLabel.Location = new System.Drawing.Point(429, 78);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(102, 22);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserNameText
            // 
            this.UserNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameText.AutoSize = true;
            this.UserNameText.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameText.ForeColor = System.Drawing.Color.Aqua;
            this.UserNameText.Location = new System.Drawing.Point(540, 79);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(0, 24);
            this.UserNameText.TabIndex = 2;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 471);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.BirthdayText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LeftPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaceTrainedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox PersonalImage;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label IntroduceOfFaceTrained;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.PictureBox FaceTrainedImage;
        private RoundButton GallerryButton;
        private RoundButton EditButton;
        private System.Windows.Forms.Label BirthdayText;
        private RoundButton EditBt;
        private RoundButton GalleryButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserNameText;
    }
}