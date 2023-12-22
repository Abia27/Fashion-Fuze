//namespace TITLEPAGE
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System;
using System.Windows.Forms;

namespace TITLEPAGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Close Form1
            // this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
