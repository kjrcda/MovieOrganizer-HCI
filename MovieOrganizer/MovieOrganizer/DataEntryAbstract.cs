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
        public static String path = ".\\pic\\";
        protected String picName = "";
        protected bool picPresent = false;
        
        public DataEntryAbstract() 
        { 
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            MaximizeBox = false;
            cmb_Rating.DataSource = Enum.GetValues(typeof(Rating)).Cast<Rating>().Select(p => new { Key = (int)p, Value = p.ToString() }).ToList();
            cmb_Rating.DisplayMember = "Value";
            cmb_Rating.ValueMember = "Key";
        }

        protected virtual void btn_Save_Movie_Click(object sender, EventArgs e)
        {
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
                picPresent = true;
            }
        }

        public String getFilename()
        {
            String extractedName = "";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (picPresent)
            {
                extractedName = Path.GetFileName(picName);
                File.Copy(picName, path + extractedName, true);
            }
            return extractedName;
        }

        protected bool ValidateInput()
        {
            bool valid = true;
            if (txt_Year.Text == "")
                txt_Year.Text = "0";
            try
            {
                int year = Convert.ToInt32(txt_Year.Text);
                if (year > 2200)
                {
                    MessageBox.Show("Year field is too high");
                    valid = false;
                }
            }
            catch
            {
                MessageBox.Show("You must enter a number into the Year field");
                valid = false;
            }

            if (txt_MovieTitle.Text == "")
            {
                MessageBox.Show("Movie Title field must not be blank");
                valid = false;
            }

            return valid;
        }

        private void DataEntryAbstract_Load(object sender, EventArgs e)
        {
            ToolTip entryTag = new ToolTip();
            entryTag.AutoPopDelay = 5000;
            entryTag.InitialDelay = 1200;
            entryTag.ReshowDelay = 500;

            entryTag.ShowAlways = true;

            entryTag.SetToolTip(txt_MovieTitle, "Enter the movie title");
            entryTag.SetToolTip(txt_Genre, "Enter the genre of the movie");
            entryTag.SetToolTip(txt_Actors, "Enter some of the actors in the movie");
            entryTag.SetToolTip(txt_Director, "Enter the movie director");
            entryTag.SetToolTip(txt_Year, "Enter the year of the movie as a number");
            entryTag.SetToolTip(txt_Description, "Enter a description of the movie");
            entryTag.SetToolTip(txt_Tags, "Enter custom words you wish to add to the movie as tags");
            entryTag.SetToolTip(pic_EditMovieImage, "Click the upload button to select a movie cover image");
        }
    }
}
