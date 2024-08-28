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


namespace BasicFacebookFeatures
{
    public partial class FormFriendsList : Form
    {
        public FormFriendsList()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FacebookAPIManager.FetchUserFriendsList(ref listBoxFriendsList);
        }

        private void listBoxFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriendInfo();
        }

        private void displaySelectedFriendInfo()
        {
            if (listBoxFriendsList.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Do you want to view info about this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    adjustLabelsState();
                }
                else if (result == DialogResult.No)
                {
                    pictureBoxFriendPhoto.Visible = true;
                    User selectedFriend = listBoxFriendsList.SelectedItem as User;

                    if (selectedFriend.PictureNormalURL != null)
                    {
                        pictureBoxFriendPhoto.LoadAsync(selectedFriend.PictureNormalURL);
                    }
                    else
                    {
                        pictureBoxFriendPhoto.Image = pictureBoxFriendPhoto.ErrorImage;
                    }
                }
            }
        }

        private void adjustLabelsState()
        {
            labelFriendBirthday.Visible = true;
            labelFriendCity.Visible = true;
            labelFriendEmail.Visible = true;
            labelFriendGender.Visible = true;
            labelFriendInfo.Visible = true;
            pictureBoxFriendPhoto.Visible = true;

            User selectedFriend = listBoxFriendsList.SelectedItem as User;
            labelFriendBirthday.Text = labelFriendBirthday.Text + selectedFriend.Birthday;
            labelFriendCity.Text = labelFriendCity.Text + selectedFriend.Location.ToString();
            labelFriendEmail.Text = labelFriendCity.Text + selectedFriend.Email;
            labelFriendGender.Text = labelFriendGender.Text + selectedFriend.Gender.ToString();
            pictureBoxFriendPhoto.LoadAsync(selectedFriend.PictureNormalURL);
        }

        private void pictureBoxFriendPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
