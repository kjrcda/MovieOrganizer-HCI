using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                txt_Tags.Text = movie.Tags;
                pic_EditMovieImage.BackgroundImage = Image.FromFile(path + movie.PictureName);
            }
        }

    }
}
