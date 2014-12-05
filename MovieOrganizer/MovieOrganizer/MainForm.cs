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
            ReadXML();
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
                    ;
                }
            }
        }

        private void btn_pDataEntry_pLibrary_Save_Click(object sender, EventArgs e)
        {
            LibraryPanel.Show();
            //alert movie changes was saved
        }

        private void btn_pDataEntry_pLibrary_Cancel_Click(object sender, EventArgs e)
        {
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            WriteXML();
        }

        private void ReadXML()
        {

        }

        private void WriteXML()
        {

        }
    }
}
