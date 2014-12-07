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
                }
                else if(result == DialogResult.OK)
                {
                    //updates movie id and replaces in master list
                    form.movie.ID = ID;
                    MainForm.movieList[MainForm.movieList.IndexOf(entry)] = form.movie;
                }
            }
            Panel obj = (Panel)this.Parent;
            MainForm.DrawList(obj);
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
    }
}
