
namespace BasicFacebookFeatures
{
    partial class FormLogin
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
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(27, 100);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(126, 22);
            this.checkBoxRememberUser.TabIndex = 59;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            this.checkBoxRememberUser.Click += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(27, 26);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(268, 24);
            this.textBoxAppID.TabIndex = 58;
            this.textBoxAppID.Text = "497382836326595";
            this.textBoxAppID.TextChanged += new System.EventHandler(this.textBoxAppID_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(27, 61);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 57;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.buttonLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Button buttonLogin;
    }
}