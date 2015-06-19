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
            cmbRating.DataSource = Enum.GetValues(typeof(Rating)).Cast<Rating>().Select(p => new { Key = (int)p, Value = p.ToString() }).ToList();
            cmbRating.DisplayMember = "Value";
            cmbRating.ValueMember = "Key";
        }

        protected virtual void btnSaveMovie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        protected void setDeleteToFalse()
        {
            btnDeleteMovie.Visible = false;
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            Dispose();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
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
                picEditMovieImage.Image = Image.FromFile(diag.FileName);
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
            if (txtYear.Text == "")
                txtYear.Text = "0";
            try
            {
                int year = Convert.ToInt32(txtYear.Text);
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

            if (txtMovieTitle.Text == "")
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

            entryTag.SetToolTip(txtMovieTitle, "Enter the movie title");
            entryTag.SetToolTip(txtGenre, "Enter the genre of the movie");
            entryTag.SetToolTip(txtActors, "Enter some of the actors in the movie");
            entryTag.SetToolTip(txtDirector, "Enter the movie director");
            entryTag.SetToolTip(txtYear, "Enter the year of the movie as a number");
            entryTag.SetToolTip(txtDescription, "Enter a description of the movie");
            entryTag.SetToolTip(txtTags, "Enter custom words you wish to add to the movie as tags");
            entryTag.SetToolTip(picEditMovieImage, "Click the upload button to select a movie cover image");
        }
    }
}
