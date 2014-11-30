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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            NavigationPanel.Hide();
            DataEntryPanel.Hide();
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

        private void btn_pMain_AddMovie_Click(object sender, EventArgs e)
        {
            using (var form = new DataEntryAbstract("Add Movie"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Add Movie Successfully!");
                }
                else
                    MessageBox.Show("Cancelled Movie Entry");
            }
        }

        private void link_pMain_pLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenuPanel.Hide();
            LibraryPanel.Show();
            NavigationPanel.Show();
        }

        private void link_pMain_pDataEntry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenuPanel.Hide();
            DataEntryPanel.Show();
            NavigationPanel.Show();
        }

        private void txt_MovieTitle_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_MovieTitle.Text))
            {
                txt_MovieTitle.Text = "Movie Title";
                txt_MovieTitle.ForeColor = Color.Gray;
            }
            else
            {
                txt_MovieTitle.ForeColor = Color.Black;
            }
        }

        private void txt_Year_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Year.Text))
            {
                txt_Year.Text = "Year";
                txt_Year.ForeColor = Color.Gray;
            }
            else
            {
                txt_Year.ForeColor = Color.Black;
            }
        }

        private void txt_Director_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Director.Text))
            {
                txt_Director.Text = "Director";
                txt_Director.ForeColor = Color.Gray;
            }
            else
            {
                txt_Director.ForeColor = Color.Black;
            }
        }

        private void txt_Actors_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Actors.Text))
            {
                txt_Actors.Text = "Actors";
                txt_Actors.ForeColor = Color.Gray;
            }
            else
            {
                txt_Actors.ForeColor = Color.Black;
            }
        }

        private void txt_Genre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Genre.Text))
            {
                txt_Genre.Text = "Genre";
                txt_Genre.ForeColor = Color.Gray;
            }
            else
            {
                txt_Genre.ForeColor = Color.Black;
            }
        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Description.Text))
            {
                txt_Description.Text = "Description";
                txt_Description.ForeColor = Color.Gray;
            }
            else
            {
                txt_Description.ForeColor = Color.Black;
            }
        }

        private void txt_Tags_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Tags.Text))
            {
                txt_Tags.Text = "Tags";
                txt_Tags.ForeColor = Color.Gray;
            }
            else
            {
                txt_Tags.ForeColor = Color.Black;
            }
        }

        private void btn_pDataEntry_pLibrary_Save_Click(object sender, EventArgs e)
        {
            DataEntryPanel.Hide();
            LibraryPanel.Show();
            //alert movie changes was saved
        }

        private void btn_pDataEntry_pLibrary_Cancel_Click(object sender, EventArgs e)
        {
            DataEntryPanel.Hide();
            LibraryPanel.Show();
            //alert movie changes was cancelled
        }

        private void btn_pDataEntry_modalConfirmation_DeleteMovie_Click(object sender, EventArgs e)
        {
            //modal popup asking for confirmation of delete movie.
            //if denied, close modal with no changes
            //if accepted, alert movie was deleted and return to library
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
