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

        protected override void btn_Save_Movie_Click(object sender, EventArgs e)
        {
            int year = 0;
            if (txt_Year.Text != "")
                year = Convert.ToInt32(txt_Year.Text);
            movie = new MovieEntry(txt_MovieTitle.Text, year, txt_Director.Text, txt_Actors.Text, (Rating)cmb_Rating.SelectedValue, txt_Genre.Text, txt_Description.Text, txt_Tags.Text, getFilename());
            base.btn_Save_Movie_Click(sender, e);
        }

    }
}
