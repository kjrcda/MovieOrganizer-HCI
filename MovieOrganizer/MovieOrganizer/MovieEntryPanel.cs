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
                pic_Movie_Icon.Image = Image.FromFile(DataEntryAbstract.path +movie.PictureName,true);
            lnk_Name.Text = movie.Title;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
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
            btn_Remove_from_list.Visible = flag;
            btn_Edit.Visible = !flag;
        }

        private void lnk_Name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenDetails();
        }

        private void pic_Movie_Icon_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void OpenDetails()
        {
            using (var form = new Details_Form(getMovie()))
            {
                form.ShowDialog();
            }
        }

        private void pic_Movie_Icon_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pic_Movie_Icon_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btn_Remove_from_list_Click(object sender, EventArgs e)
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
