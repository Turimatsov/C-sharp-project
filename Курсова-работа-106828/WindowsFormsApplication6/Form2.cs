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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") ||comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox5.SelectedIndex == -1)
                MessageBox.Show("Моля попълнете всички данни! ");
            else
            {
                string zaglavie=textBox1.Text;
                int signatura = comboBox2.SelectedIndex;
                string avtor = textBox3.Text;
                int ezik = comboBox3.SelectedIndex;
                int janr = comboBox5.SelectedIndex;
                string godina=textBox2.Text;

                FileStream database = new FileStream("knigi.dat", FileMode.OpenOrCreate);
                BinaryWriter bw = new BinaryWriter(database);
                database.Seek(0, SeekOrigin.End);
                bw.Write(zaglavie);
                bw.Write(signatura);
                bw.Write(avtor);
                bw.Write(ezik);
                bw.Write(janr);
                bw.Write(godina);
                database.Close();
                MessageBox.Show("Данните са записани");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
        }
    }
}
