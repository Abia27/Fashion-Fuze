using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TITLEPAGE;

namespace FashionFuze
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Form9 m = new Form9();

            // Show Form3
            m.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            Form8 m = new Form8();

            // Show Form3
            m.Show();
        }
    }
    
}
