using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz_Management_System.BLL;
using System.IO;

namespace BookBiz_Management_System.Validation
{
    public class BookValidation
    {
        private static string filePathBooks = Application.StartupPath + @"\Books.dat";

        public static bool isValidISBN(TextBox text)
        {
            long tempID;
            if (text.TextLength != 13 || !(Int64.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid ISBN, it must be 13 digit number", "Invalid ISBN");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }

        public static bool isValidName(TextBox name)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Title is Mandatory", "Invalid Title");
                name.Clear();
                name.Focus();
                isValid = false;
            }
            else
            {
                for (int i = 0; i < name.TextLength; i++)
                {
                    if (char.IsDigit(name.Text, i))
                    {
                        MessageBox.Show("Please enter correct Title", "Invalid Title");
                        name.Clear();
                        name.Focus();
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        public static bool isValidYear(TextBox year)
        {
            if(year.TextLength != 4)
            {
                MessageBox.Show("Please enter a valid year");
                year.Clear();
                year.Focus();
                return false;
            }
            else
            {
                for(int i=0; i<year.TextLength;i++)
                {
                    if(!char.IsDigit(year.Text, i))
                    {
                        MessageBox.Show("Please enter year correctly");
                        year.Clear();
                        year.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool isValidValues(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show("Please Enter valid Data", "Invalid Data Entered");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }

        public static bool IsUniqueID(TextBox text)
        {
            var flag = 0;
            var isValid = true;
            StreamReader sReader = new StreamReader(filePathBooks);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (Convert.ToInt64(text.Text) == Convert.ToInt64(fields[0]))
                {
                    flag = 1;
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
                line = sReader.ReadLine();

            }
            sReader.Close();
            if (flag == 1)
            {
                MessageBox.Show("Please enter unique ID");
                text.Clear();
                text.Focus();
                isValid = false;
            }
            return isValid;

        }
    }
}
