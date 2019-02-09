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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {if (textBox1.Text == "Потребителско Име") textBox1.Text = ""; textBox1.ForeColor = Color.Black;}

        private void textBox1_MouseLeave(object sender, EventArgs e)
        { if (textBox1.Text == "") { textBox1.Text = "Потребителско Име"; textBox1.ForeColor = Color.DarkGray;}}
        private void textBox1_Leave(object sender, EventArgs e)
        {if (textBox1.Text == "") { textBox1.Text = "Потребителско Име"; textBox1.ForeColor = Color.DarkGray; }}

        private void textBox1_Enter(object sender, EventArgs e)
        { if (textBox1.Text == "Потребителско Име") { textBox1.Text = ""; }  textBox1.ForeColor = Color.Black; }
        private void button1_Click(object sender, EventArgs e)
        {
            bool form = false; // дали има успех с username и password
            string username = "";
            string password = "";
            StreamReader SR = new StreamReader("Username.txt");
            StreamReader SR2 = new StreamReader("Password.txt");
            for (int i = 0; i < SR.BaseStream.Length; i++)
            {
                username = SR.ReadLine(); password=SR2.ReadLine();
                if (username == null || password == null) break;

                if (textBox1.Text == username && textBox2.Text == password) { new Form1().Show(); this.Hide();form = true; }

            }
            if (form == false) { MessageBox.Show("Неправилно потребителско име и/или парола!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}

            SR.Close();
            SR2.Close();
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        { if (textBox2.Text == "Парола") { textBox2.Text = ""; textBox2.ForeColor = Color.Black; } }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        { if (textBox2.Text == "") { textBox2.Text = "Парола"; textBox2.ForeColor = Color.DarkGray;}}

        private void textBox2_Enter(object sender, EventArgs e)
        { if (textBox2.Text == "Парола") { textBox2.Text = ""; } textBox2.ForeColor = Color.Black;}

        private void textBox2_Leave(object sender, EventArgs e)
        {if (textBox2.Text == "") { textBox2.Text = "Парола"; textBox2.ForeColor = Color.DarkGray; }}

       
    }
}
