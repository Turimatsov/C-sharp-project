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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int redNomer = 0;
            dataGridView1.Rows.Clear();
            DataTable dt = new DataTable();
            try
            {
                StreamReader streamReader = new StreamReader("DataTo.txt");
                dataGridView1.AllowUserToAddRows = false;

                string text = "";

                int godinadata = DateTime.Now.Year;
                int godinadata3 = DateTime.Now.Year - 1;
                int godinadata2 = DateTime.Now.Year - 2;

                string a = godinadata.ToString();
                string b = godinadata2.ToString();
                string c = godinadata3.ToString();

                for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                {
                    string[] masiv = text.Split(new char[] { '-' });

                    if (masiv[5] == a || masiv[5] == b || masiv[5] == c)
                    {
                        dataGridView1.Rows.Add(++redNomer, masiv[0],
                             (masiv[1] == "0") ? "Учебник" :
                             (masiv[1] == "1") ? "Творба" :
                             (masiv[1] == "2") ? "Документ" :
                             (masiv[1] == "3") ? "Автобиография" :
                             (masiv[1] == "4") ? "Бележки" : masiv[1],
                              masiv[2],
                             (masiv[3] == "0") ? "Български" :
                             (masiv[3] == "1") ? "Английски" :
                             (masiv[3] == "2") ? "Друг" : masiv[3],
                             (masiv[4] == "0") ? "Поема" :
                             (masiv[4] == "1") ? "Елегия" :
                             (masiv[4] == "2") ? "Повест" :
                             (masiv[4] == "3") ? "Роман" :
                             (masiv[4] == "4") ? "Стихотворение" :
                             (masiv[4] == "5") ? "Ода" :
                             (masiv[4] == "6") ? "Фантастика" :
                             (masiv[4] == "7") ? "Стихосбирка" :
                             (masiv[4] == "8") ? "Друг" : masiv[4], masiv[5]);
                    }
                }
                streamReader.Close();
                streamReader.Dispose();
            }
            catch (Exception err)
            { MessageBox.Show("Error" + err.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        
        {           
        }
    }
}



