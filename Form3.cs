using FashionFuze;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TITLEPAGE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {


            //Clothes clothesForm = new Clothes();
            //clothesForm.Show();
            //this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Form7 s = new Form7();

            // Show Form7
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            MakeUp m = new MakeUp();

            // Show Form3
            m.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Jewellery j= new Jewellery();

            // Show Form3
            j.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Perfume p = new Perfume();

            // Show Form3
            p.Show();

        }

       

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Jewellery j = new Jewellery();

            // Show Form3
            j.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            MakeUp m = new MakeUp();

            // Show Form3
            m.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Perfume clothes = new Perfume();

            // Show Form3
            clothes.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //perfume
            this.Hide();

            // Create an instance of Form3
            Perfume p = new Perfume();

            // Show Form3
            p.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//cart
            this.Hide();
            Form10 s = new Form10();

            // Show Form3
            s.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Form7 p = new Form7();

            // Show Form3
            p.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            Form7 p = new Form7();
            p.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form7 p = new Form7();
            p.Show();
        }
    }
}

