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
using System.Xml.Serialization;

namespace MovieOrganizer
{
    public partial class MainForm : Form
    {
        public static List<MovieEntry> movieList = new List<MovieEntry>();
        private List<ToolStripMenuItem> toolItems = new List<ToolStripMenuItem>();
        private ToolStripMenuItem current = null;
        protected int newMovieIndex;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            ReadXML();
            if (movieList.Count == 0)
                newMovieIndex = 1;
            else
                newMovieIndex = movieList[movieList.Count - 1].ID + 1;

            toolItems.Add(tlStrp_Genre);
            toolItems.Add(tlStrp_Director);
            toolItems.Add(tlStrp_Actor);
            toolItems.Add(tlStrp_Rating);
            toolItems.Add(tlStrp_RecentlyViewed);
            toolItems.Add(tlStrp_TimesWatched);
            toolItems.Add(tlStrp_Year);

            TagPanel.Hide();
            LibraryPanel.Hide();
            LoginPanel.Show();
            MainMenuPanel.Show();
            NavigationPanel.Hide();
            DrawList(panel_MovieListing);
        }

        private void link_pMain_pLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TagPanel.Hide();
            MainMenuPanel.Hide();
            LibraryPanel.Show();
            NavigationPanel.Show();
        }

        private void link_pMain_pDataEntry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new AddMovie())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var record = form.movie;
                    record.ID = newMovieIndex++;
                    movieList.Add(record);
                    link_pMain_pLibrary_LinkClicked(sender, e);
                }
            }
            DrawList(panel_MovieListing);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            WriteXML();
        }

        private void ReadXML()
        {
            var reader = new XmlSerializer(typeof(List<MovieEntry>));
            StreamReader file;

            try
            {
                file = new StreamReader("file.xml");
                var list = reader.Deserialize(file);
                movieList = (List<MovieEntry>)list;
                file.Close();
            }
            catch
            {
                MessageBox.Show("Error reading file");
                return; //then there is no file or its empty and will be created/written on exit
            }
        }

        private void WriteXML()
        {
            try
            {
                var writer = new XmlSerializer(typeof(List<MovieEntry>));
                var file = new StreamWriter("file.xml", false);
                writer.Serialize(file, movieList);
                file.Close();
            }
            catch
            {
                MessageBox.Show("Error writing to file");
            }
        }

        private void tlStrp_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            if(current == null)
            {
                temp.BackColor = SystemColors.ControlDark;
                temp.ForeColor = SystemColors.ControlLightLight;
                current = temp;
            }
            else if (current == temp)
            {
                current.ForeColor = SystemColors.ControlText;
                current.BackColor = SystemColors.Control;
                current = null;
            }
            else
            {
                current.BackColor = SystemColors.Control;
                current.ForeColor = SystemColors.ControlText;
                temp.BackColor = SystemColors.ControlDark;
                temp.ForeColor = SystemColors.ControlLightLight;
                current = temp;
            }
        }

        private void link_pMain_frmSuggest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new Suggest_Modal())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("" + form.suggest);
                    link_pMain_pLibrary_LinkClicked(sender, e);
                }
            }
        }

        public static void DrawList(Panel pan)
        {
            int pos = 3;
            pan.Controls.Clear();
            foreach (var item in movieList)
            {
                MovieEntryPanel entry = new MovieOrganizer.MovieEntryPanel();
                entry.Location = new System.Drawing.Point(1, pos);
                entry.Name = "" + item.ID;
                entry.Size = new System.Drawing.Size(465, 105);
                entry.TabIndex = 12;
                entry.setMovie(item.ID);
                pan.Controls.Add(entry);
                pos += 105;
            }
        }

        private void lnk_AddMovie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_pMain_pDataEntry_LinkClicked(sender, e);
        }

        private void lnk_Suggest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_pMain_frmSuggest_LinkClicked(sender, e);
        }

        private void lnk_Library_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!LibraryPanel.Visible)
            {
                TagPanel.Hide();
                LibraryPanel.Show();
            }
        }

        private void lnk_TagSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!TagPanel.Visible)
            {
                LibraryPanel.Hide();
                TagPanel.Show();
            }
        }

        private void link_pMain_pTaggedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenuPanel.Hide();
            NavigationPanel.Show();
            lnk_TagSearch_LinkClicked(sender, e);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (current == null)
            {

            }
            else if (current == tlStrp_Genre)
            {

            }
            else if (current == tlStrp_Actor)
            {

            }
            else if (current == tlStrp_Director)
            {

            }
            else if (current == tlStrp_Year)
            {

            }
            else if (current == tlStrp_Rating)
            {

            }
            else
                MessageBox.Show("Unable to Search");
        }

        private void list_availableTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
