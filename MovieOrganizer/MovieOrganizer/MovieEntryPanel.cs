using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieOrganizer
{
    [System.ComponentModel.Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public partial class MovieEntryPanel : UserControl
    {
        int ID;
        public MovieEntryPanel()
        {
            InitializeComponent();
            SetRemove(false);
        }

        public void setMovie(int ID)
        {
            this.ID = ID;
            MovieEntry movie = getMovie();
            
            if(movie.PictureName !="" && File.Exists(DataEntryAbstract.path +movie.PictureName))
                picMovieIcon.Image = Image.FromFile(DataEntryAbstract.path +movie.PictureName,true);
            lnkName.Text = movie.Title;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MovieEntry entry = getMovie();
            using(var form = new EditMovie(entry))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.Ignore)
                {
                    //delete movie and picture from file
                    if (File.Exists(DataEntryAbstract.path + entry.PictureName))
                    {
                        //would like to delete file if possible - not required
                    }
                    MainForm.movieList.Remove(entry);

                    //delete from user lists too
                    foreach (var list in MainForm.userList)
                    {
                        list.Remove(entry.ID);
                    }
                }
                else if(result == DialogResult.OK)
                {
                    //updates movie id and replaces in master list
                    form.movie.ID = ID;
                    MainForm.movieList[MainForm.movieList.IndexOf(entry)] = form.movie;
                }
            }
            DrawList();
        }

        private MovieEntry getMovie()
        {
            MovieEntry temp = null;
            foreach (var entry in MainForm.movieList)
            {
                if (entry.ID == ID)
                {
                    temp = entry;
                    break;
                }
            }
            return temp;
        }
        
        public void SetRemove(bool flag)
        {
            btnListRemove.Visible = flag;
            btnEdit.Visible = !flag;
        }

        private void lnkName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenDetails();
        }

        private void picMovieIcon_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void OpenDetails()
        {
            using (var form = new DetailsForm(getMovie()))
            {
                form.ShowDialog();
            }
        }

        private void picMovieIcon_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picMovieIcon_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnListRemove_Click(object sender, EventArgs e)
        {
            var list = MainForm.currentList.Text;
            int listNum = -1;
            if (list == "Watch Next")
                listNum=0;
            if (list == "Gift Movies")
                listNum = 1;
            if (list == "My Wishlist")
                listNum = 2;
            if (listNum >= 0)
                MainForm.userList[listNum].Remove(ID);
            DrawList();
            MainForm.currentList = null;
        }

        private void DrawList()
        {
            Panel obj = (Panel)this.Parent;
            MainForm.DrawList(obj);
        }
    }
}
