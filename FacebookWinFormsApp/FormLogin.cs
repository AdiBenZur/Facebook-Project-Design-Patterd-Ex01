using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private LoginResult m_LoginResult;
        private XmlFileManager m_XmlManager;
        public FormLogin()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = Int32.MaxValue;
            m_XmlManager = XmlFileManager.LoadFromFile();
            checkBoxRememberUser.Checked = m_XmlManager.RememberMe;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_XmlManager.RememberMe
                && !string.IsNullOrEmpty(m_XmlManager.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_XmlManager.LastAccessToken);
                initProfileForm();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_XmlManager.RememberMe = checkBoxRememberUser.Checked;
            if (m_XmlManager.RememberMe)
            {
                m_XmlManager.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_XmlManager.LastAccessToken = null;
            }
            m_XmlManager.SaveToFile();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_XmlManager.RememberMe
                && !string.IsNullOrEmpty(m_XmlManager.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_XmlManager.LastAccessToken);
                initProfileForm();
            }
            else
            {
                loginAndInitProfileForm();
            }
        }

        private void loginAndInitProfileForm()
        {
            m_LoginResult = FacebookService.Login(
                textBoxAppID.Text,
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_XmlManager.LastAccessToken = m_LoginResult.AccessToken;
                initProfileForm();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void initProfileForm()
        {
            FormProfile formProfile = new FormProfile(m_LoginResult);
            formProfile.ShowDialog();
            if (formProfile.ClosedByX)
            {
                this.Close();
            }
            else//closed by logout
            {
                m_XmlManager.LastAccessToken = null;
                m_XmlManager.RememberMe = false;
            }
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            m_XmlManager.RememberMe = checkBoxRememberUser.Checked;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAppID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
