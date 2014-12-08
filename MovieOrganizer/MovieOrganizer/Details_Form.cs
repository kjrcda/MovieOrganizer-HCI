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
        int ID;
        public Details_Form(MovieEntry entry)
        {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            MaximizeBox = false;
            if(entry.PictureName !="")
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
            ID = entry.ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_Wish_Click(object sender, EventArgs e)
        {
            MainForm.userList[2].Add(ID);
            Dispose();
        }

        private void btn_Gift_Click(object sender, EventArgs e)
        {
            MainForm.userList[1].Add(ID);
            Dispose();
        }

        private void btn_Watch_Click(object sender, EventArgs e)
        {
            MainForm.userList[0].Add(ID);
            Dispose();
        }
    }
}
