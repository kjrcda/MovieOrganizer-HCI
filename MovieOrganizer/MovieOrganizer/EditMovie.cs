using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class EditMovie : DataEntryAbstract
    {
        public EditMovie(MovieEntry entry)
        {
            InitializeComponent();
            movie = entry;
            if (movie != null)
            {
                txt_MovieTitle.Text = movie.Title;
                txt_Year.Text = "" + movie.Year;
                txt_Director.Text = movie.Director;
                txt_Actors.Text = movie.Actors;
                cmb_Rating.SelectedValue = (int)movie.Rate;
                txt_Description.Text = movie.Description;
                txt_Genre.Text = movie.Genre;
                txt_Tags.Text = movie.Tags;
                if (movie.PictureName != "")
                {
                    picName = path+ movie.PictureName;
                    pic_EditMovieImage.Image = Image.FromFile(picName);   
                }
            }
        }

        protected override void btn_Save_Movie_Click(object sender, EventArgs e)
        {
            movie.Title = txt_MovieTitle.Text;
            movie.Year = Convert.ToInt32(txt_Year.Text);
            movie.Director = txt_Director.Text;
            movie.Actors = txt_Actors.Text;
            movie.Rate = (Rating)cmb_Rating.SelectedValue;
            movie.Description = txt_Description.Text;
            movie.Genre = txt_Genre.Text;
            movie.Tags = txt_Tags.Text;
            movie.PictureName = picPresent ? getFilename() : Path.GetFileName(picName);
            base.btn_Save_Movie_Click(sender, e);
        }

    }
}
