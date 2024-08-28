using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class FacebookAPIManager
    {
        public static void FetchUserFriendsList(ref ListBox io_ListBoxFriends)
        {
            io_ListBoxFriends.Items.Clear();
            io_ListBoxFriends.DisplayMember = "Name";

            try
            {
                foreach (User friend in FormProfile.LoggedInUser.Friends)
                {
                    io_ListBoxFriends.Items.Add(friend);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (io_ListBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No friends to retrieve!");
            }
        }

        public static void FetchUserPosts(ref ListBox io_ListBoxPost)
        {
            io_ListBoxPost.Items.Clear();

            try
            {
                foreach (Post post in FormProfile.LoggedInUser.WallPosts)
                {
                    if (post.Message != null)
                    {
                        io_ListBoxPost.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        io_ListBoxPost.Items.Add(post.Caption);
                    }
                    else
                    {
                        io_ListBoxPost.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (io_ListBoxPost.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve!");
            }
        }

        public static void FetchCommentsOnSelectedPost(Post i_SelectedPost, ref ListBox io_ListBoxComments)
        {
            io_ListBoxComments.Items.Clear();
            io_ListBoxComments.DisplayMember = "Name";
            try
            {
                foreach (Comment comment in i_SelectedPost.Comments)
                {
                    io_ListBoxComments.Items.Add(comment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (io_ListBoxComments.Items.Count == 0)
            {
                MessageBox.Show("No Comments to retrieve!");
            }
        }

        public static void FetchLikesOnSelectedPost(Post i_SelectedPost, ref ListBox io_ListBoxComments)
        {
            io_ListBoxComments.Items.Clear();
            io_ListBoxComments.DisplayMember = "Name";
            try
            {
                foreach (User user in i_SelectedPost.LikedBy)
                {
                    io_ListBoxComments.Items.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (io_ListBoxComments.Items.Count == 0)
            {
                MessageBox.Show("No Likes to retrieve :(");
            }
        }

        public static void FetchUserAlbums(ref ListBox io_ListBoxAlbums)
        {
            io_ListBoxAlbums.Items.Clear();
            io_ListBoxAlbums.DisplayMember = "Name";
            try
            {
                foreach (Album album in FormProfile.LoggedInUser.Albums)
                {
                    io_ListBoxAlbums.Items.Add(album);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (io_ListBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve!");
            }
        }

        public static void FetchUserEvents(ref ListBox io_ListBoxEvents)
        {
            io_ListBoxEvents.Items.Clear();
            io_ListBoxEvents.DisplayMember = "Name";
            try
            {
                foreach (Event fbEvent in FormProfile.LoggedInUser.Events)
                {
                    io_ListBoxEvents.Items.Add(fbEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (io_ListBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve!");
            }
        }

        public static void FetchUserLikedPages(ref ListBox io_ListBoxLikedPages)
        {
            io_ListBoxLikedPages.Items.Clear();
            io_ListBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in FormProfile.LoggedInUser.LikedPages)
                {
                    io_ListBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (io_ListBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve!");
            }
        }

        public static void FetchProfilePictureWithMostLikes(ref PictureBox io_PictureBoxPhoto)
        {
            try
            {
                Album ProfileAlbum = null;
                foreach (Album album in FormProfile.LoggedInUser.Albums)
                {
                    if (album.Type == Album.eType.Profile)
                    {
                        ProfileAlbum = album;
                        break;
                    }
                }

                Photo MostLikedPhoto = null;
                bool isFirstPhoto = true;
                foreach (Photo photo in ProfileAlbum.Photos)
                {
                    if (isFirstPhoto)
                    {
                        MostLikedPhoto = photo;
                        isFirstPhoto = false;
                    }
                    else
                    {
                        if (MostLikedPhoto.LikedBy.Count < photo.LikedBy.Count)
                        {
                            MostLikedPhoto = photo;
                        }
                    }
                }

                if (MostLikedPhoto.PictureNormalURL != null)
                {

                    io_PictureBoxPhoto.LoadAsync(MostLikedPhoto.PictureNormalURL);
                }
                else
                {
                    io_PictureBoxPhoto.Image = io_PictureBoxPhoto.ErrorImage;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FetchProfilePictureWithMostComments(ref PictureBox io_PictureBoxPhoto)
        {
            try
            {
                Album ProfileAlbum = null;
                foreach (Album album in FormProfile.LoggedInUser.Albums)
                {
                    if (album.Type == Album.eType.Profile)
                    {
                        ProfileAlbum = album;
                        break;
                    }
                }

                Photo MostCommentPhoto = null;
                int count = 0;
                foreach (Photo photo in ProfileAlbum.Photos)
                {
                    if (count == 0)
                    {
                        MostCommentPhoto = photo;
                        count++;
                    }
                    else
                    {
                        if (MostCommentPhoto.Comments.Count < photo.Comments.Count)
                        {
                            MostCommentPhoto = photo;
                        }
                    }
                }

                if (MostCommentPhoto.PictureNormalURL != null)
                {

                    io_PictureBoxPhoto.LoadAsync(MostCommentPhoto.PictureNormalURL);
                }
                else
                {
                    io_PictureBoxPhoto.Image = io_PictureBoxPhoto.ErrorImage;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SetStatus(TextBox i_TextBoxStatus)
        {
            try
            {
                Status postedStatus = FormProfile.LoggedInUser.PostStatus(i_TextBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
