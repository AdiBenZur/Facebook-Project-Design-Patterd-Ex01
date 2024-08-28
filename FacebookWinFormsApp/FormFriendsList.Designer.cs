
namespace BasicFacebookFeatures
{
    partial class FormFriendsList
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
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.pictureBoxFriendPhoto = new System.Windows.Forms.PictureBox();
            this.labelFriendBirthday = new System.Windows.Forms.Label();
            this.labelFriendGender = new System.Windows.Forms.Label();
            this.labelFriendCity = new System.Windows.Forms.Label();
            this.labelFriendEmail = new System.Windows.Forms.Label();
            this.labelFriendInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.Location = new System.Drawing.Point(-2, 2);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(226, 368);
            this.listBoxFriendsList.TabIndex = 1;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // pictureBoxFriendPhoto
            // 
            this.pictureBoxFriendPhoto.Location = new System.Drawing.Point(443, 23);
            this.pictureBoxFriendPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFriendPhoto.Name = "pictureBoxFriendPhoto";
            this.pictureBoxFriendPhoto.Size = new System.Drawing.Size(146, 118);
            this.pictureBoxFriendPhoto.TabIndex = 2;
            this.pictureBoxFriendPhoto.TabStop = false;
            this.pictureBoxFriendPhoto.Visible = false;
            this.pictureBoxFriendPhoto.Click += new System.EventHandler(this.pictureBoxFriendPhoto_Click);
            // 
            // labelFriendBirthday
            // 
            this.labelFriendBirthday.AutoSize = true;
            this.labelFriendBirthday.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendBirthday.ForeColor = System.Drawing.Color.SlateGray;
            this.labelFriendBirthday.Location = new System.Drawing.Point(448, 216);
            this.labelFriendBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendBirthday.Name = "labelFriendBirthday";
            this.labelFriendBirthday.Size = new System.Drawing.Size(69, 17);
            this.labelFriendBirthday.TabIndex = 12;
            this.labelFriendBirthday.Text = "Birthday: ";
            this.labelFriendBirthday.Visible = false;
            // 
            // labelFriendGender
            // 
            this.labelFriendGender.AutoSize = true;
            this.labelFriendGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendGender.ForeColor = System.Drawing.Color.SlateGray;
            this.labelFriendGender.Location = new System.Drawing.Point(448, 186);
            this.labelFriendGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendGender.Name = "labelFriendGender";
            this.labelFriendGender.Size = new System.Drawing.Size(64, 17);
            this.labelFriendGender.TabIndex = 11;
            this.labelFriendGender.Text = "Gender: ";
            this.labelFriendGender.Visible = false;
            // 
            // labelFriendCity
            // 
            this.labelFriendCity.AutoSize = true;
            this.labelFriendCity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendCity.ForeColor = System.Drawing.Color.SlateGray;
            this.labelFriendCity.Location = new System.Drawing.Point(449, 247);
            this.labelFriendCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendCity.Name = "labelFriendCity";
            this.labelFriendCity.Size = new System.Drawing.Size(41, 17);
            this.labelFriendCity.TabIndex = 10;
            this.labelFriendCity.Text = "City: ";
            this.labelFriendCity.Visible = false;
            // 
            // labelFriendEmail
            // 
            this.labelFriendEmail.AutoSize = true;
            this.labelFriendEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendEmail.ForeColor = System.Drawing.Color.SlateGray;
            this.labelFriendEmail.Location = new System.Drawing.Point(449, 276);
            this.labelFriendEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendEmail.Name = "labelFriendEmail";
            this.labelFriendEmail.Size = new System.Drawing.Size(53, 17);
            this.labelFriendEmail.TabIndex = 9;
            this.labelFriendEmail.Text = "Email: ";
            this.labelFriendEmail.Visible = false;
            // 
            // labelFriendInfo
            // 
            this.labelFriendInfo.AutoSize = true;
            this.labelFriendInfo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelFriendInfo.Location = new System.Drawing.Point(444, 158);
            this.labelFriendInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendInfo.Name = "labelFriendInfo";
            this.labelFriendInfo.Size = new System.Drawing.Size(127, 19);
            this.labelFriendInfo.TabIndex = 8;
            this.labelFriendInfo.Text = "About the user:";
            this.labelFriendInfo.Visible = false;
            // 
            // FormFriendsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelFriendBirthday);
            this.Controls.Add(this.labelFriendGender);
            this.Controls.Add(this.labelFriendCity);
            this.Controls.Add(this.labelFriendEmail);
            this.Controls.Add(this.labelFriendInfo);
            this.Controls.Add(this.pictureBoxFriendPhoto);
            this.Controls.Add(this.listBoxFriendsList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormFriendsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.PictureBox pictureBoxFriendPhoto;
        private System.Windows.Forms.Label labelFriendBirthday;
        private System.Windows.Forms.Label labelFriendGender;
        private System.Windows.Forms.Label labelFriendCity;
        private System.Windows.Forms.Label labelFriendEmail;
        private System.Windows.Forms.Label labelFriendInfo;
    }
}