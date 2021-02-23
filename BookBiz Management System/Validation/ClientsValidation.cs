using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BookBiz_Management_System.BLL;

namespace BookBiz_Management_System.Validation
{
    public class ClientsValidation
    {
        private static string filePathClients = Application.StartupPath + @"\Clients.dat";

        public static bool isValidID(TextBox text)
        {
            int tempID;
            if (text.TextLength != 3 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid Client ID, it must be 3 digit number", "Invalid ID");
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
                MessageBox.Show("Name is Mandatory", "Invalid Name");
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
                        MessageBox.Show("Please enter correct Name", "Invalid Name");
                        name.Clear();
                        name.Focus();
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        public static bool isValidValues(TextBox text)
        {
            if(string.IsNullOrEmpty(text.Text))
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
            StreamReader sReader = new StreamReader(filePathClients);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (Convert.ToInt32(text.Text) == Convert.ToInt32(fields[0]))
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
