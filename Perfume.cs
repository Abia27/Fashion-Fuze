﻿using FashionFuze;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TITLEPAGE
{
    public partial class Perfume : Form
    {
        public Perfume()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            MakeUp m = new MakeUp();

            // Show Form3
            m.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            MakeUp s = new MakeUp();

            // Show Form3
            s.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
       

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Form7 s = new Form7();

            // Show Form3
            s.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Jewellery j = new Jewellery();

            // Show Form3
            j.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Perfume P = new Perfume();

            // Show Form3
            P.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form10 s = new Form10();

            // Show Form3
            s.Show();
        }
    }
}
