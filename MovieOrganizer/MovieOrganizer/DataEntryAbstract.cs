using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        public String path = ".\\pic";
        String picName = "";
        
        public DataEntryAbstract() 
        { 
            InitializeComponent();
            cmb_Rating.DataSource = Enum.GetValues(typeof(Rating)).Cast<Rating>().Select(p => new { Key = (int)p, Value = p.ToString() }).ToList();
            cmb_Rating.DisplayMember = "Value";
            cmb_Rating.ValueMember = "Key";
        }

        protected virtual void btn_Save_Movie_Click(object sender, EventArgs e)
        {
            String extractedName = Path.GetFileName(picName);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            File.Copy(picName, path + extractedName, true);
            movie = new MovieEntry(txt_MovieTitle.Text, Convert.ToInt32(txt_Year.Text), txt_Director.Text, txt_Actors.Text, (Rating)cmb_Rating.SelectedValue, txt_Description.Text, txt_Tags.Text, extractedName);

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

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            var imageExtensions = string.Join(";", ImageCodecInfo.GetImageDecoders().Select(ici => ici.FilenameExtension));
            String filter = string.Format("Images|{0}|", imageExtensions);
            diag.Filter = filter.Substring(0, filter.Length-1);
            diag.FilterIndex = 1;

            DialogResult result = diag.ShowDialog();

            if (result == DialogResult.OK)
            {
                picName = diag.FileName; 
                pic_EditMovieImage.Image = Image.FromFile(diag.FileName);
            }
        }

    }
}
