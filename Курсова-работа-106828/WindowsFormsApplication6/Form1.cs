using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void данниToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void въведиДанниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void справкаЗаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаПоЖанрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void поемаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
              

        private void поАвторИлиЗаглавиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void книгиОтПоследните3ГодиниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void tXTFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }
    }
}
