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
    public partial class Details_Form : Form
    {
        public Details_Form(MovieEntry entry)
        {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            MaximizeBox = false;
            pic_Cover.Image = Image.FromFile(DataEntryAbstract.path + entry.PictureName);
            lbl_Movie_Title.Text = entry.Title;
            lbl_Description.Text = entry.Description;
            lbl_Director.Text = entry.Director;
            lbl_Genre.Text = entry.Genre;
            lbl_Year.Text = ""+entry.Year;
            String rate = "";
            for(int i=(int)entry.Rate;i > 0; i--)
                rate+="★";
            for(int i= 5-(int)entry.Rate; i>0; i--)
                rate+="☆";
            lbl_Rating.Text = rate;
            lbl_Actors.Text = entry.Actors;
            lbl_Tags.Text = entry.Tags;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
