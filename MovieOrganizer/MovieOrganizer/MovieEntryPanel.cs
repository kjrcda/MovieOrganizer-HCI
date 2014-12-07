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
            MovieEntry movie = MainForm.movieList[this.ID-1];
            if(movie.PictureName !="")
                pic_Movie_Icon.Image = Image.FromFile(DataEntryAbstract.path +movie.PictureName);
            lnk_Name.Text = movie.Title;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            using(var form = new EditMovie(MainForm.movieList[ID-1]))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.Ignore)
                {
                    //delete movie and picture from file
                    MovieEntry delete = MainForm.movieList[ID - 1];
                    if (File.Exists(delete.PictureName))
                    {
                        try
                        {
                            File.Delete(delete.PictureName);
                        }
                        catch (IOException ioe)
                        {
                            MessageBox.Show(ioe.Message);
                        }
                    }
                    MainForm.movieList.Remove(delete);
                }
                else if(result == DialogResult.OK)
                {
                    //updates movie id and replaces in master list
                    form.movie.ID = ID;
                    MainForm.movieList[ID-1] = form.movie;
                }
            }
            Panel obj = (Panel)this.Parent;
            MainForm.DrawList(obj);
        }
    }
}
