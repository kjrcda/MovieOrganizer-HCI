﻿using System;
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
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }
    }
}
