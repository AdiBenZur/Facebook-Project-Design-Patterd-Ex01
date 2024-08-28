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
    public partial class FormPosts : Form
    {
        public FormPosts()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FacebookAPIManager.FetchUserPosts(ref listBoxPosts);
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = FormProfile.LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            FormSelectedPost selectedPost = new FormSelectedPost(selected);
            selectedPost.ShowDialog();
        }
    }
}
