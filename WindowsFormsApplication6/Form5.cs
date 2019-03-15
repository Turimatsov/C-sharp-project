using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication6;

namespace WindowsFormsApplication6
{
    public partial class Form5 : Form
    {

        DGV_Controll dgv = new DGV_Controll();
        public Form5()
        {
            InitializeComponent(); this.ControlBox = false;
            dgv.prochetiFile(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DGV_Combobox(dataGridView1, comboBox1);
            if (comboBox1.SelectedIndex != -1) { label1.Text = ""; } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
