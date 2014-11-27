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
        }

        //syntax is objectType_panelObjectIsOn_panelObjectPointsTo
        private void btn_pLibrary_ViewMain_Click(object sender, EventArgs e)
        {
            LibraryPanel.Hide();
            NavigationPanel.Hide();
            MainMenuPanel.Show();
        }

        private void btn_pMain_ViewLibrary_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Hide();
            LibraryPanel.Show();
            NavigationPanel.Show();
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
    }
}
