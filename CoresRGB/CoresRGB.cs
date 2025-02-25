﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace CoresRGB
{
    public partial class CoresRGB : Form
    {
        public CoresRGB()
        {
            InitializeComponent();
        }

        public void MesclarCores()
        {
            lblPainel.BackColor = Color.FromArgb(
                hScrollBarRed.Value,
                hScrollBarGreen.Value,
                hScrollBarBlue.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblNumRed.Text = hScrollBarRed.Value.ToString();
            MesclarCores();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblNumGreen.Text = hScrollBarGreen.Value.ToString();
            MesclarCores();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblNumBlue.Text = hScrollBarBlue.Value.ToString();
            MesclarCores();
        }
    }
}
