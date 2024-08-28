
namespace BasicFacebookFeatures
{
    partial class FormSelectedPost
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
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.listBoxLikes = new System.Windows.Forms.ListBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxComments
            // 
            this.listBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComments.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(0, 138);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(200, 225);
            this.listBoxComments.TabIndex = 0;
            // 
            // listBoxLikes
            // 
            this.listBoxLikes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLikes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxLikes.FormattingEnabled = true;
            this.listBoxLikes.Location = new System.Drawing.Point(389, 138);
            this.listBoxLikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLikes.Name = "listBoxLikes";
            this.listBoxLikes.Size = new System.Drawing.Size(200, 225);
            this.listBoxLikes.TabIndex = 0;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(192, 11);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(196, 106);
            this.pictureBoxPhoto.TabIndex = 1;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Visible = false;
            // 
            // FormSelectedPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.listBoxLikes);
            this.Controls.Add(this.listBoxComments);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormSelectedPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.ListBox listBoxLikes;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
    }
}