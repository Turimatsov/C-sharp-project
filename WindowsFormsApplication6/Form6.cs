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
    public partial class Form6 : Form
    {

        DGV_Controll DGV = new DGV_Controll();
        public Form6()
        {
            InitializeComponent(); this.ControlBox = false;
            DGV.prochetiFile(dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DGV.Last3Years(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
    }
}



