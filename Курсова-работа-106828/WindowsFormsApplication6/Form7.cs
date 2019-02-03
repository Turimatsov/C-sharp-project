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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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

                dataGridView1.Rows.Add(nomer++, zaglavie,

                    (sig == 1) ? "Тип: Учебник" :
                    (sig == 2) ? "Тип: Творба" :
                    (sig == 3) ? "Тип: Документ" :
                    (sig == 4) ? "Тип: Автобиография" :
                    (sig == 5) ? "Тип: Бележки" : "Тип: Бележки",

                    avtor,
                    (ezik == 0) ? "Език: Български" :
                    (ezik == 1) ? "Език: Английски" :
                    (ezik == 2) ? "Език: Друг" : "Език: Друг",

                    (janr == 0) ? "Жанр: Поема" :
                    (janr == 1) ? "Жанр: Елегия" :
                    (janr == 2) ? "Жанр: Повест" :
                    (janr == 3) ? "Жанр: Роман" :
                    (janr == 4) ? "Жанр: Стихотворение" :
                    (janr == 5) ? "Жанр: Ода" :
                    (janr == 6) ? "Жанр: Фантастика" :
                    (janr == 7) ? "Жанр: Стихосбирка" :
                    (janr == 8) ? "Жанр: Друг" : "Жанр: Друг", godina+"г.");
            }
            database.Close();
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
        private void Form7_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            writer.WriteLine("Дата и час на запис \t" + DateTime.Now);
            writer.WriteLine("----------------------------------------------------------");
            writer.Close();
            MessageBox.Show("Данните са записани!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
