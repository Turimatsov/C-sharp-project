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
            if (textBox1.Text == "" && textBox2.Text=="") MessageBox.Show("Липсват данни! "); 
            else
            {
                FileStream database = new FileStream("knigi.dat", FileMode.Open);
                BinaryReader br = new BinaryReader(database);
                dataGridView1.Rows.Clear();
                int nomer = 1;
                while (database.Position < database.Length)
                {
                    string zaglavie = br.ReadString();
                    int sig = br.ReadInt32();
                    string avtor = br.ReadString();
                    int ezik = br.ReadInt32();
                    int janr = br.ReadInt32();
                    string godina = br.ReadString();

                    if (zaglavie==textBox1.Text||avtor==textBox2.Text)
                    {                   
                        dataGridView1.Rows.Add(nomer++, zaglavie,

                            (sig == 1) ? "Учебник" :
                            (sig == 2) ? "Творба" :
                            (sig == 3) ? "Документ" :
                            (sig == 4) ? "Автобиография" :
                            (sig == 5) ? "Бележки" : "Бележки",

                            avtor,
                            (ezik == 0) ? "Български" :
                            (ezik == 1) ? "Английски" :
                            (ezik == 2) ? "Друг" : "",

                            (janr == 0) ? "Поема" :
                            (janr == 1) ? "Елегия" :
                            (janr == 2) ? "Повест" :
                            (janr == 3) ? "Роман" :
                            (janr == 4) ? "Стихотворение" :
                            (janr == 5) ? "Ода" :
                            (janr == 6) ? "Фантастика" :
                            (janr == 7) ? "Стихосбирка" :
                            (janr == 8) ? "Друг" : "Друг", godina);
                    }
                    
                }
                database.Close();
            }
        }
    }
}
