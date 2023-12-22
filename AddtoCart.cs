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

namespace TITLEPAGE
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form3
            SignIn m = new SignIn();

            // Show Form3
            m.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
