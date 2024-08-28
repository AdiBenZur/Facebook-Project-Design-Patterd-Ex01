using FacebookWrapper;

namespace BasicFacebookFeatures
{
    partial class FormAllPhotosInAlbum
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
            this.labelNumberOfPhotos = new System.Windows.Forms.Label();
            this.flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNameOfAlbum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumberOfPhotos
            // 
            this.labelNumberOfPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberOfPhotos.AutoSize = true;
            this.labelNumberOfPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPhotos.Location = new System.Drawing.Point(15, 46);
            this.labelNumberOfPhotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfPhotos.Name = "labelNumberOfPhotos";
            this.labelNumberOfPhotos.Size = new System.Drawing.Size(241, 18);
            this.labelNumberOfPhotos.TabIndex = 0;
            this.labelNumberOfPhotos.Text = "The number of photos in the album:";
            // 
            // flowLayoutPanelPhotos
            // 
            this.flowLayoutPanelPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPhotos.AutoScroll = true;
            this.flowLayoutPanelPhotos.Location = new System.Drawing.Point(18, 68);
            this.flowLayoutPanelPhotos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
            this.flowLayoutPanelPhotos.Size = new System.Drawing.Size(334, 288);
            this.flowLayoutPanelPhotos.TabIndex = 1;
            // 
            // labelNameOfAlbum
            // 
            this.labelNameOfAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameOfAlbum.AutoSize = true;
            this.labelNameOfAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfAlbum.Location = new System.Drawing.Point(15, 20);
            this.labelNameOfAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameOfAlbum.Name = "labelNameOfAlbum";
            this.labelNameOfAlbum.Size = new System.Drawing.Size(163, 18);
            this.labelNameOfAlbum.TabIndex = 0;
            this.labelNameOfAlbum.Text = "The name of the album:";
            // 
            // FormAllPhotosInAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 366);
            this.Controls.Add(this.flowLayoutPanelPhotos);
            this.Controls.Add(this.labelNameOfAlbum);
            this.Controls.Add(this.labelNumberOfPhotos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAllPhotosInAlbum";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.FormAllPhotosInAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfPhotos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.Label labelNameOfAlbum;
    }
}