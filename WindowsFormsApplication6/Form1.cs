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
            InitializeComponent(); this.ControlBox = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте? ", "Излизане", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                Close();
        }
        private void въведиДанниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show(); this.Hide();
        }
        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show(); this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void справкаПоЖанрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().Show(); this.Hide();
        }
        private void поАвторИлиЗаглавиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show(); this.Hide();
        }
        private void книгиОтПоследните3ГодиниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().Show(); this.Hide();
        }

        private void tXTFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7().Show(); this.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
