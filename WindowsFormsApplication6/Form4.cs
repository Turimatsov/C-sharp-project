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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "") MessageBox.Show("Липсват данни! ");
            else
            {
                int redNomer = 0;
                dataGridView1.Rows.Clear();
                    DataTable dt = new DataTable();
                    try
                    {
                        StreamReader streamReader = new StreamReader("DataTo.txt");
                        dataGridView1.AllowUserToAddRows = false;

                        string text = "";
                        for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                        {
                        string[] masiv = text.Split(new char[] {'-'});
                        if (masiv[0] == textBox1.Text||masiv[2]==textBox2.Text)
                        { dataGridView1.Rows.Add(++redNomer,masiv[0], masiv[1], masiv[2], masiv[3], masiv[4], masiv[5]); }
                        }
                        streamReader.Close();
                    }
                    catch (Exception err)
                    { MessageBox.Show("Error" + err.Message); }
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {if (textBox1.Text == "Име на творбата") textBox1.Text = "";}

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {if (textBox1.Text == "") {textBox1.Text = "Име на творбата";}}

        private void textBox2_MouseHover(object sender, EventArgs e)
        {if (textBox2.Text == "Автор на творбата") textBox2.Text = "";}

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {if (textBox2.Text == "") { textBox2.Text = "Автор на творбата"; }}
    }
}
