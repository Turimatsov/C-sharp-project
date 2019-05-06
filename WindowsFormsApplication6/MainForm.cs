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
        Books_Control control = new Books_Control();
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
            new AddBook().Show(); this.Hide();
        }
        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show(); this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:MM:SS");
        }
        private void справкаПоЖанрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ByGenre().Show(); this.Hide();
        }
        private void поАвторИлиЗаглавиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ByNameOrAuthor().Show(); this.Hide();
        }
        private void книгиОтПоследните3ГодиниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LastThreeYears().Show(); this.Hide();
        }

        private void tXTFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TxtFile().Show(); this.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
