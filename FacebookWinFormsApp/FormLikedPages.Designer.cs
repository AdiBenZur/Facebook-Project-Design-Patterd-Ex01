
namespace BasicFacebookFeatures
{
    partial class FormLikedPages
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
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(91, 105);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(480, 160);
            this.listBoxLikedPages.TabIndex = 5;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(220, 11);
            this.pictureBoxLikedPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(183, 90);
            this.pictureBoxLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikedPage.TabIndex = 6;
            this.pictureBoxLikedPage.TabStop = false;
            this.pictureBoxLikedPage.Visible = false;
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 366);
            this.Controls.Add(this.pictureBoxLikedPage);
            this.Controls.Add(this.listBoxLikedPages);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormLikedPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxLikedPage;
    }
}