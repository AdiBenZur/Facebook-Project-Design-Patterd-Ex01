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
    public partial class FormSelectedPost : Form
    {
        private Post m_SelectedPost;
        public FormSelectedPost(Post i_SelectedPost)
        {
            InitializeComponent();
            m_SelectedPost = i_SelectedPost;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FacebookAPIManager.FetchCommentsOnSelectedPost(m_SelectedPost, ref listBoxComments);
            FacebookAPIManager.FetchLikesOnSelectedPost(m_SelectedPost, ref listBoxComments);
            displayImageFromPost();
        }

        private void displayImageFromPost()
        {
            if (m_SelectedPost.Type == Post.eType.photo)
            {
                pictureBoxPhoto.Visible = true;
                pictureBoxPhoto.LoadAsync(m_SelectedPost.PictureURL);
            }
        }

    }
}
