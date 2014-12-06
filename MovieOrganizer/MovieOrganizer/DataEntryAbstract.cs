using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class DataEntryAbstract : Form
    {
        public MovieEntry movie;
        
        public DataEntryAbstract() 
        { 
            InitializeComponent();
            cmb_Rating.DataSource = Enum.GetValues(typeof(Rating)).Cast<Rating>().Select(p => new { Key = (int)p, Value = p.ToString() }).ToList();
            cmb_Rating.DisplayMember = "Value";
            cmb_Rating.ValueMember = "Key";
        }

        protected virtual void btn_Save_Movie_Click(object sender, EventArgs e)
        {
            movie = new MovieEntry(txt_MovieTitle.Text, Convert.ToInt32(txt_Year.Text), txt_Director.Text, txt_Actors.Text, (Rating)cmb_Rating.SelectedValue, txt_Description.Text, txt_Tags.Text);

            DialogResult = DialogResult.OK;
            Dispose();
        }

        protected virtual void btn_Cancel_Movie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        protected void setDeleteToFalse()
        {
            btn_Delete_Movie.Visible = false;
        }

        private void btn_Delete_Movie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            Dispose();
        }

    }
}
