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

namespace WindowsFormsApplication6
{
    public partial class Form3 : Form
    {
        DGV_Controll dgv = new DGV_Controll();
        public Form3()
        {
            InitializeComponent(); this.ControlBox = false;
            dgv.prochetiFile(dataGridView1);
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            Close(); //exit
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Изтрива се редът и след това останалото се записва наново във файлът.

            int indexRed = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(indexRed);

            //===========================================================
            dgv.saveDGVtoTXT(dataGridView1);
            //сега наново прочитаме презаписаният файл
            dgv.prochetiFile(dataGridView1);
        } 

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        { new Form1().Show();}
    }
}




        

    

