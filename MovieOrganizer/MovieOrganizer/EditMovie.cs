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
                txtMovieTitle.Text = movie.Title;
                txtYear.Text = "" + movie.Year;
                txtDirector.Text = movie.Director;
                txtActors.Text = movie.Actors;
                cmbRating.SelectedValue = (int)movie.Rate;
                txtDescription.Text = movie.Description;
                txtGenre.Text = movie.Genre;
                txtTags.Text = movie.Tags;
                if (movie.PictureName != "")
                {
                    picName = path+ movie.PictureName;
                    picEditMovieImage.Image = Image.FromFile(picName);   
                }
            }
        }

        protected override void btnSaveMovie_Click(object sender, EventArgs e)
        {
            if (base.ValidateInput())
            {
                movie.Title = txtMovieTitle.Text;
                movie.Year = Convert.ToInt32(txtYear.Text);
                movie.Director = txtDirector.Text;
                movie.Actors = txtActors.Text;
                movie.Rate = (Rating)cmbRating.SelectedValue;
                movie.Description = txtDescription.Text;
                movie.Genre = txtGenre.Text;
                movie.Tags = txtTags.Text;
                movie.PictureName = picPresent ? getFilename() : Path.GetFileName(picName);
                base.btnSaveMovie_Click(sender, e);
            }
        }

    }
}
