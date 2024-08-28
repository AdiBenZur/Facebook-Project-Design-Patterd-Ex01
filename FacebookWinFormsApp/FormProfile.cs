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
    public partial class FormProfile : Form
    {
        private static User s_LoggedInUser;
        private bool m_ClosedByX = true;
        private const string k_PlaceholderText = "What would you like to share ?";

        public FormProfile(LoginResult i_LoginResult)
        {
            InitializeComponent();
            s_LoggedInUser = i_LoginResult.LoggedInUser;
        }

        public static User LoggedInUser { get { return s_LoggedInUser; } }

        public bool ClosedByX
        {
            get { return m_ClosedByX; }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            buttonLogin.Text = $"Logged in as {s_LoggedInUser.Name}";
            buttonLogin.AutoSize = true;
            buttonLogin.BackColor = Color.LightGreen;
            buttonLogout.BackColor = Color.Red;
            pictureBoxProfile.ImageLocation = s_LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            labelGender.Text = labelGender.Text + s_LoggedInUser.Gender.ToString();
            labelBirthday.Text = labelBirthday.Text + s_LoggedInUser.Birthday;
            labelCity.Text = labelCity.Text + s_LoggedInUser.Location.ToString();
            labelEmail.Text = labelEmail.Text + s_LoggedInUser.Email;
            textBoxStatus.Text = k_PlaceholderText;
            textBoxStatus.ForeColor = SystemColors.GrayText;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            FacebookService.LogoutWithUI();
            m_ClosedByX = false;
            this.Close();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            FacebookAPIManager.SetStatus(textBoxStatus);
            textBoxStatus.Text = k_PlaceholderText;
        }

        private void textBoxStatus_Enter(object sender, EventArgs e)
        {
            if (textBoxStatus.Text == k_PlaceholderText)
            {
                textBoxStatus.Text = string.Empty;
                textBoxStatus.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxStatus_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                textBoxStatus.Text = k_PlaceholderText;
                textBoxStatus.ForeColor = SystemColors.GrayText;
            }
        }

        private void buttonGetFriends_Click(object sender, EventArgs e)
        {
            FormFriendsList friendsList = new FormFriendsList();
            friendsList.ShowDialog();
        }

        private void buttonGetAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums albums = new FormAlbums();
            albums.ShowDialog();
        }

        private void buttonGetEvents_Click(object sender, EventArgs e)
        {
            FormEvents events = new FormEvents();
            events.ShowDialog();
        }

        private void buttonGetLikedPages_Click(object sender, EventArgs e)
        {
            FormLikedPages likedPages = new FormLikedPages();
            likedPages.ShowDialog();
        }

        private void buttonGetPosts_Click(object sender, EventArgs e)
        {
            FormPosts posts = new FormPosts();
            posts.ShowDialog();
        }

        private void buttonGetMostedLikeProfilPicture_Click(object sender, EventArgs e)
        {
            FormMostLikedProfilePicture mostLikedPhoto = new FormMostLikedProfilePicture();
            mostLikedPhoto.ShowDialog();
        }

        private void buttonMostCommentProfilePicture_Click(object sender, EventArgs e)
        {
            FormMostCommentsProfilePicture mostLikedPhoto = new FormMostCommentsProfilePicture();
            mostLikedPhoto.ShowDialog();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
