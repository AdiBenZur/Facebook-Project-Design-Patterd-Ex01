
namespace BasicFacebookFeatures
{
    partial class FormMostCommentsProfilePicture
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
            this.pictureBoxMostCommentsPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostCommentsPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMostCommentsPhoto
            // 
            this.pictureBoxMostCommentsPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMostCommentsPhoto.Location = new System.Drawing.Point(213, 85);
            this.pictureBoxMostCommentsPhoto.Name = "pictureBoxMostCommentsPhoto";
            this.pictureBoxMostCommentsPhoto.Size = new System.Drawing.Size(371, 283);
            this.pictureBoxMostCommentsPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostCommentsPhoto.TabIndex = 0;
            this.pictureBoxMostCommentsPhoto.TabStop = false;
            // 
            // FormMostCommentsProfilePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.facebookLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxMostCommentsPhoto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMostCommentsProfilePicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostCommentsPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion.
        private System.Windows.Forms.PictureBox pictureBoxMostCommentsPhoto;
    }
}