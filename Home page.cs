﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ditec
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnfacilities_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void btnupcomingevents_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }
    }
}
