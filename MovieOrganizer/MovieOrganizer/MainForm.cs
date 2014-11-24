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
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            using(var form = new DataEntryAbstract("Add Movie"))
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
