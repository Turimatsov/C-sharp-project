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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileStream database = new FileStream("knigi.dat", FileMode.Open);
            BinaryReader br = new BinaryReader(database);
            dataGridView1.Rows.Clear();
            int nomer = 1;
            while (database.Position < database.Length)
            {
                string zaglavie = br.ReadString();
                int sig = br.ReadInt32();
                string avtor=br.ReadString();
                int ezik = br.ReadInt32();
                int janr = br.ReadInt32();
                string godina = br.ReadString();



                if (janr == comboBox1.SelectedIndex)

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

                    (janr == 1) ? "Поема" :
                    (janr == 2) ? "Елегия" :
                    (janr == 3) ? "Повест" :
                    (janr == 4) ? "Роман" :
                    (janr == 5) ? "Стихотворение" :
                    (janr == 6) ? "Ода" :
                    (janr == 7) ? "Фантастика" :
                    (janr == 8) ? "Стихосбирка" :
                    (janr == 9) ? "Друг" : "Друг", godina);

                }

            }
            database.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
