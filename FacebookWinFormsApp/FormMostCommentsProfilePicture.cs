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
    public partial class FormMostCommentsProfilePicture : Form
    {
        public FormMostCommentsProfilePicture()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FacebookAPIManager.FetchProfilePictureWithMostComments(ref pictureBoxMostCommentsPhoto);
        }
    }
}

