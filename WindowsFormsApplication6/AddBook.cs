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
    public partial class AddBook : Form
    {
        public AddBook()
        {InitializeComponent(); this.ControlBox = false;}
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("Заглавие") || !textBox2.Text.Equals("Година") || textBox3.Text.Equals("Автор") || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox5.SelectedIndex == -1)
                MessageBox.Show("Моля попълнете всички данни! ");
            else
            {
                string zaglavie = textBox1.Text;
                int signatura = comboBox2.SelectedIndex;
                string avtor = textBox3.Text;
                int ezik = comboBox3.SelectedIndex;
                int janr = comboBox5.SelectedIndex;
                string godina = textBox2.Text;

                using (StreamWriter w = File.AppendText("DataTo.txt"))
                {
                    w.WriteLine(zaglavie.ToString() + "-"
                    +signatura.ToString() + "-"
                    + avtor.ToString() + "-"
                    + ezik.ToString() + "-"
                    + janr.ToString() + "-"
                    + godina.ToString());
                }
                MessageBox.Show("Данните са записани");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
                textBox1.Text = "Заглавие";  textBox1.ForeColor = Color.DarkGray;
                textBox2.Text = "Година"; textBox2.ForeColor = Color.DarkGray;
                textBox3.Text = "Автор"; textBox3.ForeColor = Color.DarkGray;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {new Form1().Show();}

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("Заглавие") || !textBox2.Text.Equals("Година") || !textBox3.Text.Equals("Автор") || comboBox2.SelectedIndex != -1 || comboBox3.SelectedIndex != -1 || comboBox5.SelectedIndex != -1)
            {
                if (MessageBox.Show("Има незапазени данни! Сигурни ли сте, че искате да излезете? ", "Излизане", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {Close();}
            }else Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {if (comboBox2.SelectedIndex != -1) { label2.Hide(); } else label2.Show();}

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {if (comboBox3.SelectedIndex != -1) { label4.Hide(); } else label4.Show();}

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {if (comboBox5.SelectedIndex != -1) { label6.Hide(); } else label6.Show();}

        private void textBox1_Enter(object sender, EventArgs e)
        {if (textBox1.Text == "Заглавие") { textBox1.Text = ""; }textBox1.ForeColor = Color.Black;}

        private void textBox1_Leave(object sender, EventArgs e)
        {if (textBox1.Text == "") { textBox1.Text = "Заглавие"; textBox1.ForeColor = Color.DarkGray; }}
        private void textBox1_MouseEnter(object sender, EventArgs e)
        { if (textBox1.Text == "Заглавие") {textBox1.Text = ""; textBox1.ForeColor = Color.Black; }}

        private void textBox1_MouseLeave(object sender, EventArgs e)
        { if (textBox1.Text == "") { textBox1.Text = "Заглавие"; textBox1.ForeColor = Color.DarkGray; }}

        private void textBox3_Enter(object sender, EventArgs e)
        {if (textBox3.Text == "Автор") { textBox3.Text = ""; } textBox3.ForeColor = Color.Black; }

        private void textBox3_Leave(object sender, EventArgs e)
        { if (textBox3.Text == "") { textBox3.Text = "Автор"; textBox3.ForeColor = Color.DarkGray; }}

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {if (textBox3.Text == "Автор") textBox3.Text = ""; textBox3.ForeColor = Color.Black; }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {if (textBox3.Text == "") { textBox3.Text = "Автор"; textBox3.ForeColor = Color.DarkGray; } }

        private void textBox2_Enter(object sender, EventArgs e)
        {if (textBox2.Text == "Година") { textBox2.Text = ""; } textBox2.ForeColor = Color.Black;}

        private void textBox2_Leave(object sender, EventArgs e)
        {if (textBox2.Text == "") { textBox2.Text = "Година"; textBox2.ForeColor = Color.DarkGray; }}

        private void textBox2_MouseEnter(object sender, EventArgs e)
        { if (textBox2.Text == "Година") { textBox2.Text = ""; textBox2.ForeColor = Color.DarkGray; } }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        { if (textBox2.Text == "") { textBox2.Text = "Година"; textBox2.ForeColor = Color.DarkGray; } }

        
    }
}
