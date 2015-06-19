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

        private void btnOK_Click(object sender, EventArgs e)
        {
            newTag = txtNewTag.Text;
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

        private void AddTag_Load(object sender, EventArgs e)
        {
            ToolTip TagTip = new ToolTip();
            TagTip.AutoPopDelay = 5000;
            TagTip.InitialDelay = 1200;
            TagTip.ReshowDelay = 500;

            TagTip.ShowAlways = true;

            TagTip.SetToolTip(txtNewTag, "Enter a tag name to create. Must not be empty.");
        }
    }
}
