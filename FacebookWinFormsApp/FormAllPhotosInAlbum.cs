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
    public partial class FormAllPhotosInAlbum : Form
    {
        private readonly Album r_SelectedAlbum;

        public FormAllPhotosInAlbum(Album i_SelectedAlbum)
        {
            InitializeComponent();
            r_SelectedAlbum = i_SelectedAlbum;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            labelNumberOfPhotos.Text = labelNumberOfPhotos.Text + r_SelectedAlbum.Photos.Count.ToString();
            labelNameOfAlbum.Text = labelNameOfAlbum.Text + r_SelectedAlbum.Name;
            displayAllPhotos();
        }

        private void displayAllPhotos()
        {

            int photoCounter = 0;

            foreach (Photo photo in r_SelectedAlbum.Photos)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.LoadAsync(photo.PictureNormalURL);

                flowLayoutPanelPhotos.Controls.Add(pictureBox);

                photoCounter++;

                if (photoCounter % 3 == 0)
                {
                    flowLayoutPanelPhotos.SetFlowBreak(pictureBox, true);
                }
            }
        }

        private void FormAllPhotosInAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
