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
    public class OrderValidation
    {
        private static string filePathClients = Application.StartupPath + @"\Clients.dat";
        private static string filePathBooks = Application.StartupPath + @"\Books.dat";
        private static string filePathOrders = Application.StartupPath + @"\Orders.dat";

        public static bool isValidID(TextBox text)
        {
            int tempID;
            if (text.TextLength != 5 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid Order ID, it must be 5 digit number", "Invalid ID");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }

        public static bool isValidClient(TextBox text)
        {
            var flag = 0;
            var isValid = true;
            StreamReader sReader = new StreamReader(filePathClients);
            string line = sReader.ReadLine();

            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show("Please Enter Client ID");
                isValid = false;
                text.Clear();
                text.Focus();
            }
            else
            {
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(text.Text) == Convert.ToInt32(fields[0]))
                    {
                        isValid = true;
                        flag = 1;
                    }
                    else
                    {
                        isValid = false;
                    }

                    line = sReader.ReadLine();

                }
                sReader.Close();
                if (flag != 1)
                {
                    MessageBox.Show("Client ID not found, Please try again");
                    text.Clear();
                    text.Focus();
                }
            }

            return isValid;
        }

        public static bool isValidBooks(TextBox text)
        {
            var flag = 0;
            var isValid = true;
            StreamReader sReader = new StreamReader(filePathBooks);
            string line = sReader.ReadLine();

            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show("Please Enter ISBN");
                isValid = false;
                text.Clear();
                text.Focus();
            }
            else
            {
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (text.Text == fields[0])
                    {
                        isValid = true;
                        flag = 1;
                    }
                    else
                    {
                        isValid = false;
                    }

                    line = sReader.ReadLine();

                }
                sReader.Close();
                if (flag != 1)
                {
                    MessageBox.Show("Book ID not found, Please try again");
                    text.Clear();
                    text.Focus();
                }
            }

            return isValid;
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
            StreamReader sReader = new StreamReader(filePathOrders);
            string line = sReader.ReadLine();

                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(text.Text) == Convert.ToInt32(fields[0]))
                    {
                    flag = 1;
                    isValid= false;
                    }
                    else
                    {
                        isValid= true;
                    }
                    line = sReader.ReadLine();

                }
                sReader.Close();
            if(flag==1)
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
