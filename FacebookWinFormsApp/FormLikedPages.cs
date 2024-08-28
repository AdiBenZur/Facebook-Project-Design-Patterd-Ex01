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
    public partial class FormLikedPages : Form
    {
        public FormLikedPages()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FacebookAPIManager.FetchUserLikedPages(ref listBoxLikedPages);
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                pictureBoxLikedPage.Visible = true;
                Page page = listBoxLikedPages.SelectedItem as Page;
                if (page.PictureNormalURL != null)
                {

                    pictureBoxLikedPage.LoadAsync(page.PictureNormalURL);
                }
                else
                {
                    pictureBoxLikedPage.Image = pictureBoxLikedPage.ErrorImage;
                }
            }
        }


    }
}
