﻿using System;
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
            
            if(movie.PictureName !="")
                pic_Movie_Icon.Image = Image.FromFile(DataEntryAbstract.path +movie.PictureName);
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
                    if (File.Exists(entry.PictureName))
                    {
                        try
                        {
                            File.Delete(entry.PictureName);
                        }
                        catch (IOException ioe)
                        {
                            MessageBox.Show(ioe.Message);
                        }
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
    }
}
