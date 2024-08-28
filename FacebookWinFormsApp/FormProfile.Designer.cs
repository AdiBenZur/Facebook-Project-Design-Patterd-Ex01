
namespace BasicFacebookFeatures
{
    partial class FormProfile
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.buttonGetFriends = new System.Windows.Forms.Button();
            this.buttonGetAlbums = new System.Windows.Forms.Button();
            this.buttonGetEvents = new System.Windows.Forms.Button();
            this.buttonGetPosts = new System.Windows.Forms.Button();
            this.buttonGetLikedPages = new System.Windows.Forms.Button();
            this.buttonMostCommentProfilePicture = new System.Windows.Forms.Button();
            this.buttonGetMostedLikeProfilPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogout.Location = new System.Drawing.Point(16, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(62, 30);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(83, 10);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(63, 30);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(16, 45);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(132, 118);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(10, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "About the user:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.SlateGray;
            this.labelEmail.Location = new System.Drawing.Point(12, 388);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 18);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.SlateGray;
            this.labelGender.Location = new System.Drawing.Point(10, 302);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(68, 18);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.Color.SlateGray;
            this.labelBirthday.Location = new System.Drawing.Point(11, 332);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(73, 18);
            this.labelBirthday.TabIndex = 7;
            this.labelBirthday.Text = "Birthday: ";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.Color.SlateGray;
            this.labelCity.Location = new System.Drawing.Point(10, 361);
            this.labelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(43, 18);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City: ";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostStatus.Location = new System.Drawing.Point(12, 212);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(87, 18);
            this.labelPostStatus.TabIndex = 8;
            this.labelPostStatus.Text = "Post status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(15, 232);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(215, 24);
            this.textBoxStatus.TabIndex = 9;
            this.textBoxStatus.Enter += new System.EventHandler(this.textBoxStatus_Enter);
            this.textBoxStatus.Leave += new System.EventHandler(this.textBoxStatus_Leave);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStatus.Location = new System.Drawing.Point(233, 231);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(75, 27);
            this.buttonSetStatus.TabIndex = 10;
            this.buttonSetStatus.Text = "post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // buttonGetFriends
            // 
            this.buttonGetFriends.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetFriends.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetFriends.Location = new System.Drawing.Point(364, 32);
            this.buttonGetFriends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetFriends.Name = "buttonGetFriends";
            this.buttonGetFriends.Size = new System.Drawing.Size(209, 36);
            this.buttonGetFriends.TabIndex = 13;
            this.buttonGetFriends.Text = "Display friends";
            this.buttonGetFriends.UseVisualStyleBackColor = true;
            this.buttonGetFriends.Click += new System.EventHandler(this.buttonGetFriends_Click);
            // 
            // buttonGetAlbums
            // 
            this.buttonGetAlbums.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetAlbums.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetAlbums.Location = new System.Drawing.Point(364, 86);
            this.buttonGetAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetAlbums.Name = "buttonGetAlbums";
            this.buttonGetAlbums.Size = new System.Drawing.Size(209, 36);
            this.buttonGetAlbums.TabIndex = 13;
            this.buttonGetAlbums.Text = "Display albums";
            this.buttonGetAlbums.UseVisualStyleBackColor = true;
            this.buttonGetAlbums.Click += new System.EventHandler(this.buttonGetAlbums_Click);
            // 
            // buttonGetEvents
            // 
            this.buttonGetEvents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetEvents.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetEvents.Location = new System.Drawing.Point(364, 139);
            this.buttonGetEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetEvents.Name = "buttonGetEvents";
            this.buttonGetEvents.Size = new System.Drawing.Size(209, 36);
            this.buttonGetEvents.TabIndex = 13;
            this.buttonGetEvents.Text = "Display events";
            this.buttonGetEvents.UseVisualStyleBackColor = true;
            this.buttonGetEvents.Click += new System.EventHandler(this.buttonGetEvents_Click);
            // 
            // buttonGetPosts
            // 
            this.buttonGetPosts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetPosts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetPosts.Location = new System.Drawing.Point(364, 192);
            this.buttonGetPosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetPosts.Name = "buttonGetPosts";
            this.buttonGetPosts.Size = new System.Drawing.Size(209, 36);
            this.buttonGetPosts.TabIndex = 13;
            this.buttonGetPosts.Text = "Display posts";
            this.buttonGetPosts.UseVisualStyleBackColor = true;
            this.buttonGetPosts.Click += new System.EventHandler(this.buttonGetPosts_Click);
            // 
            // buttonGetLikedPages
            // 
            this.buttonGetLikedPages.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetLikedPages.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetLikedPages.Location = new System.Drawing.Point(363, 244);
            this.buttonGetLikedPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetLikedPages.Name = "buttonGetLikedPages";
            this.buttonGetLikedPages.Size = new System.Drawing.Size(209, 36);
            this.buttonGetLikedPages.TabIndex = 13;
            this.buttonGetLikedPages.Text = "Display liked pages";
            this.buttonGetLikedPages.UseVisualStyleBackColor = true;
            this.buttonGetLikedPages.Click += new System.EventHandler(this.buttonGetLikedPages_Click);
            // 
            // buttonMostCommentProfilePicture
            // 
            this.buttonMostCommentProfilePicture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostCommentProfilePicture.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonMostCommentProfilePicture.Location = new System.Drawing.Point(364, 346);
            this.buttonMostCommentProfilePicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMostCommentProfilePicture.Name = "buttonMostCommentProfilePicture";
            this.buttonMostCommentProfilePicture.Size = new System.Drawing.Size(209, 36);
            this.buttonMostCommentProfilePicture.TabIndex = 13;
            this.buttonMostCommentProfilePicture.Text = "Display most comments profile picture";
            this.buttonMostCommentProfilePicture.UseVisualStyleBackColor = true;
            this.buttonMostCommentProfilePicture.Click += new System.EventHandler(this.buttonMostCommentProfilePicture_Click);
            // 
            // buttonGetMostedLikeProfilPicture
            // 
            this.buttonGetMostedLikeProfilPicture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetMostedLikeProfilPicture.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetMostedLikeProfilPicture.Location = new System.Drawing.Point(364, 296);
            this.buttonGetMostedLikeProfilPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetMostedLikeProfilPicture.Name = "buttonGetMostedLikeProfilPicture";
            this.buttonGetMostedLikeProfilPicture.Size = new System.Drawing.Size(209, 36);
            this.buttonGetMostedLikeProfilPicture.TabIndex = 13;
            this.buttonGetMostedLikeProfilPicture.Text = "Display most liked profile picture";
            this.buttonGetMostedLikeProfilPicture.UseVisualStyleBackColor = true;
            this.buttonGetMostedLikeProfilPicture.Click += new System.EventHandler(this.buttonGetMostedLikeProfilPicture_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.buttonGetMostedLikeProfilPicture);
            this.Controls.Add(this.buttonMostCommentProfilePicture);
            this.Controls.Add(this.buttonGetPosts);
            this.Controls.Add(this.buttonGetLikedPages);
            this.Controls.Add(this.buttonGetEvents);
            this.Controls.Add(this.buttonGetAlbums);
            this.Controls.Add(this.buttonGetFriends);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.Button buttonGetFriends;
        private System.Windows.Forms.Button buttonGetAlbums;
        private System.Windows.Forms.Button buttonGetEvents;
        private System.Windows.Forms.Button buttonGetPosts;
        private System.Windows.Forms.Button buttonGetLikedPages;
        private System.Windows.Forms.Button buttonMostCommentProfilePicture;
        private System.Windows.Forms.Button buttonGetMostedLikeProfilPicture;
    }
}