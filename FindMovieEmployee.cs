﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_GROUP_PROJECT
{
    public partial class FindMovieEmployee : Form
    {
        Form1 ths;
        public FindMovieEmployee(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new EmployeeWelcomePage(ths));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ths.loadBigForms(new OrderConfirmationEmployee(ths));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
