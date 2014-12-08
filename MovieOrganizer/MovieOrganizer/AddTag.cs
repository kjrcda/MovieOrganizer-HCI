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
    public partial class AddTag : Form
    {
        public String newTag;

        public AddTag()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            newTag = txt_New_Tag.Text;
            if (newTag != "")
            {
                DialogResult = DialogResult.OK;
                Dispose();
            }
            else
            {
                MessageBox.Show("Cannot add a blank Tag");
            }
        }
    }
}
