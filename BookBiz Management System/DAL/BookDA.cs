using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBiz_Management_System.BLL;
using System.Windows.Forms;
using System.IO;

namespace BookBiz_Management_System.DAL
{
    public class BookDA
    {
        private static string filePath = Application.StartupPath + @"\Books.dat";

        public static void Add(Books book)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.YearPublished + "," + book.QOH);
            sWriter.Close();
            MessageBox.Show("Book has been added to the list", "Confirmation");
        }

        public static void ListBook(ListView listViewBook)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewBook.Items.Clear();

            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                item.SubItems.Add(fields[4]);
                listViewBook.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static Books Search(long isbn)
        {
            Books book = new Books();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (isbn == Convert.ToInt64(fields[0]))
                {
                    book.ISBN = Convert.ToInt64(fields[0]);
                    book.Title = fields[1];
                    book.UnitPrice = Convert.ToInt32(fields[2]);
                    book.YearPublished = Convert.ToInt32(fields[3]);
                    book.QOH = Convert.ToInt32(fields[4]);
                    sReader.Close();
                    return book;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}
