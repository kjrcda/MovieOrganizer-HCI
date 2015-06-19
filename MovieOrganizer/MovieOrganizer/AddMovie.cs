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
    public partial class AddMovie : DataEntryAbstract
    {
        public AddMovie()
        {
            InitializeComponent();
            setDeleteToFalse();
        }

        protected override void btnSaveMovie_Click(object sender, EventArgs e)
        {
            if (base.ValidateInput())
            {
                movie = new MovieEntry(txtMovieTitle.Text, Convert.ToInt32(txtYear.Text), txtDirector.Text, txtActors.Text, (Rating)cmbRating.SelectedValue, txtGenre.Text, txtDescription.Text, txtTags.Text, getFilename());
                base.btnSaveMovie_Click(sender, e);
            }
        }

    }
}
