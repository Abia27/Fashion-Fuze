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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace TITLEPAGE
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            MakeUp m = new MakeUp();

            // Show Form3
            m.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Jewellery m = new Jewellery();

            // Show Form3
            m.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Perfume m = new Perfume();

            // Show Form3
            m.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Form6 m = new Form6();

            // Show Form3
            m.Show();
        }
        //blah blah
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Form10 m = new Form10();

            // Show Form3
            m.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form10 s = new Form10();

            // Show Form3
            s.Show();
        }
    }

    //private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    //{

    //}

    //private void button3_Click(object sender, EventArgs e)
    //{

    //}

}
