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
        private List<MovieEntry> movieList = new List<MovieEntry>();
        protected int newMovieIndex;

        public MainForm()
        {
            InitializeComponent();
            ReadXML();
            if(movieList.Count==0)
                newMovieIndex =1;
            else
                newMovieIndex = movieList[movieList.Count - 1].ID + 1;

            NavigationPanel.Hide();
            LibraryPanel.Hide();
            LoginPanel.Show();
            MainMenuPanel.Show();

        }

        //syntax is objectType_panelObjectIsOn_panelObjectPointsTo
        private void btn_pLibrary_ViewMain_Click(object sender, EventArgs e)
        {
            LibraryPanel.Hide();
            NavigationPanel.Hide();
            MainMenuPanel.Show();
        }

        private void link_pMain_pLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
                var file = new StreamWriter("file.xml",false);
                writer.Serialize(file, movieList);
                file.Close();
            }
            catch
            {
                MessageBox.Show("Error writing to file");
            }
        }
    }
}
