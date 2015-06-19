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
    public partial class DetailsForm : Form
    {
        int ID;
        public DetailsForm(MovieEntry entry)
        {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            MaximizeBox = false;
            if(entry.PictureName !="")
                picCover.Image = Image.FromFile(DataEntryAbstract.path + entry.PictureName);
            lblMovieTitle.Text = entry.Title;
            lblDescription.Text = entry.Description;
            lblDirector.Text = entry.Director;
            lblGenre.Text = entry.Genre;
            lblYear.Text = ""+entry.Year;
            String rate = "";
            for(int i=(int)entry.Rate; i>0 ; i--)
                rate+="★";
            for(int i= 5-(int)entry.Rate; i>0 ; i--)
                rate+="☆";
            lblRating.Text = rate;
            lblActors.Text = entry.Actors;
            lblTags.Text = entry.Tags;
            ID = entry.ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnWish_Click(object sender, EventArgs e)
        {
            MainForm.userList[2].Add(ID);
            Dispose();
        }

        private void btnGift_Click(object sender, EventArgs e)
        {
            MainForm.userList[1].Add(ID);
            Dispose();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            MainForm.userList[0].Add(ID);
            Dispose();
        }
    }
}
