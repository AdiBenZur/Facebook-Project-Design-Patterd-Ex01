
namespace BasicFacebookFeatures
{
    partial class FormAlbums
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbumPhoto = new System.Windows.Forms.PictureBox();
            this.labelAlbumsNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(24, 80);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(568, 277);
            this.listBoxAlbums.TabIndex = 3;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxAlbumPhoto
            // 
            this.pictureBoxAlbumPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAlbumPhoto.Location = new System.Drawing.Point(412, 232);
            this.pictureBoxAlbumPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAlbumPhoto.Name = "pictureBoxAlbumPhoto";
            this.pictureBoxAlbumPhoto.Size = new System.Drawing.Size(172, 124);
            this.pictureBoxAlbumPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumPhoto.TabIndex = 4;
            this.pictureBoxAlbumPhoto.TabStop = false;
            this.pictureBoxAlbumPhoto.Visible = false;
            this.pictureBoxAlbumPhoto.Click += new System.EventHandler(this.pictureBoxAlbumPhoto_Click);
            // 
            // labelAlbumsNumber
            // 
            this.labelAlbumsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlbumsNumber.AutoSize = true;
            this.labelAlbumsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumsNumber.Location = new System.Drawing.Point(14, 38);
            this.labelAlbumsNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbumsNumber.Name = "labelAlbumsNumber";
            this.labelAlbumsNumber.Size = new System.Drawing.Size(160, 18);
            this.labelAlbumsNumber.TabIndex = 2;
            this.labelAlbumsNumber.Text = "The number of albums:";
            this.labelAlbumsNumber.Click += new System.EventHandler(this.labelAlbumsNumber_Click);
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBoxAlbumPhoto);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.labelAlbumsNumber);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbumPhoto;
        private System.Windows.Forms.Label labelAlbumsNumber;
    }
}