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
    public partial class Form7 : Form
    {
        DGV_Controll dgv = new DGV_Controll();
        public Form7()
        {
            InitializeComponent(); this.ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("Spravka-Knigi.txt");
            listBox1.Items.Clear();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                listBox1.Items.Add(line);
            }
            file.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.prochetiFile(dataGridView1);


            TextWriter writer = new StreamWriter("Spravka-Knigi.txt");
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                {
                    writer.Write("  " + dataGridView1.Rows[i].Cells[j].Value.ToString() + "  " + '|');
                }
                writer.WriteLine("");
                writer.WriteLine("");
            }
            writer.WriteLine("");
            writer.WriteLine("----------------------------------------------------------");
            writer.WriteLine("Дата и час на запис: \t" + DateTime.Now);
            writer.WriteLine("----------------------------------------------------------");
            writer.Close();
            MessageBox.Show("Данните са записани!");
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
    }
}
