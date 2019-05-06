using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;//!!!

namespace WindowsFormsApplication6
{
    class Books_Control
    {
    public List<string> spisakKnigi = new List<string>();
    public void Last3Years(DataGridView dgv)
        {
            dgv.Rows.Clear();
            int redNomer = 0;
            try
            {
                StreamReader streamReader = new StreamReader("DataTo.txt");

                string text = "";
                string godinadata = Convert.ToString(DateTime.Now.Year);
                string godinadata2 = Convert.ToString(DateTime.Now.Year - 1);
                string godinadata3 = Convert.ToString(DateTime.Now.Year - 2);


                for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                {
                    string[] masiv = text.Split(new char[] { '-' });
                    if (masiv[5] == godinadata || masiv[5] == godinadata2 || masiv[5] == godinadata3)
                    {
                        dgv.Rows.Add(++redNomer, masiv[0],
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
    public void saveDGVtoTXT(DataGridView dgv)
        {
            try
            {
                TextWriter sW = new StreamWriter("DataTo.txt");//записвам останалите резултати във файла
                int numRows1 = dgv.Rows.Count;
                for (int row = 0; row < numRows1; row++)
                {
                    string redove = "";
                    for (int col = 1; col < dgv.ColumnCount; col++)
                    {
                        redove += (string.IsNullOrEmpty(redove) ? "" : "-") + dgv.Rows[row].Cells[col].Value.ToString();
                    }
                    sW.WriteLine(redove);//LINE !!!!
                }
                sW.Close();
                sW.Dispose();
            }catch (Exception err)
            { MessageBox.Show("Error" + err.Message); }
} //заради изтриването
    public void DGV_Genre(DataGridView dgv, ComboBox CB)
        {
            int redNomer = 0;
            dgv.Rows.Clear();
            try
            {
                dgv.AllowUserToAddRows = false;
                
                foreach(string kniga in spisakKnigi)
                {
                    string[] masiv = kniga.Split(new char[] { '-' });

                    if (CB.SelectedItem.ToString().Equals(masiv[4].ToString()))
                    {
                        dgv.Rows.Add(++redNomer, masiv[0],masiv[1],masiv[2],masiv[3],masiv[4], masiv[5]);
                    }
                }
            }
            catch (Exception err)
            { MessageBox.Show("Error" + err.Message); }
        } //ок
    public void ReadTXT()
    {
        Books book = new Books();
        try
        {
            StreamReader streamReader = new StreamReader("DataTo.txt");
            string text = "";
            for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
            {
                string[] masiv = text.Split(new char[] { '-' });
                book.Name = masiv[0];
                book.Signature = masiv[1];
                book.Author = masiv[2];
                book.Language = masiv[3];
                book.Genre = masiv[4];
                book.Year = masiv[5];

                spisakKnigi.Add(book.Name + "-" + book.Signature + "-" + book.Author + "-" + book.Language + "-" + book.Genre + "-" + book.Year);
            }
            streamReader.Close(); streamReader.Dispose();
        }
        catch (Exception err)
        { MessageBox.Show("Error" + err.Message); }
    } //работи
    public void FillDGV(DataGridView dgv) //работи
        {
            try
            {
                ReadTXT();
                int redNomer = 1;
                foreach (string kniga in spisakKnigi)
                {
                    string[] masiv = kniga.Split('-');
                    dgv.Rows.Add(redNomer++, masiv[0], masiv[1], masiv[2], masiv[3], masiv[4], masiv[5]);
                }
            }
            catch (Exception err)
            { MessageBox.Show("Error" + err.Message); }
}
    }
}
