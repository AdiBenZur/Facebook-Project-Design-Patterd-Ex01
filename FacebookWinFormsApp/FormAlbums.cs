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
    public partial class FormAlbums : Form
    {
        public FormAlbums()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            labelAlbumsNumber.Text = labelAlbumsNumber.Text + FormProfile.LoggedInUser.Albums.Count.ToString();
            FacebookAPIManager.FetchUserAlbums(ref listBoxAlbums);
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                DialogResult result = MessageBox.Show("Do you want to view all photos in this album?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    FormAllPhotosInAlbum photos = new FormAllPhotosInAlbum(selectedAlbum);
                    photos.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    pictureBoxAlbumPhoto.Visible = true;
                    if (selectedAlbum.PictureAlbumURL != null)
                    {
                        pictureBoxAlbumPhoto.LoadAsync(selectedAlbum.PictureAlbumURL);
                    }
                    else
                    {
                        pictureBoxAlbumPhoto.Image = pictureBoxAlbumPhoto.ErrorImage;
                    }
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {

        }

        private void labelAlbumsNumber_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAlbumPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
