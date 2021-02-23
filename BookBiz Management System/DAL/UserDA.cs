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
    public class UserDA
    {
        private static string filePath = Application.StartupPath + @"\Users.dat";

        public static void Add(User user)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(user.UserID + "," + user.Designation + "," + user.EmployeeID);
            sWriter.Close();
            MessageBox.Show("User has been added to the list", "Confirmation");
        }

        public static void ListUsers(ListView listViewUsers)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewUsers.Items.Clear();

            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                listViewUsers.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static User Search(int userID)
        {
            User user = new User();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userID == Convert.ToInt32(fields[0]))
                {
                    user.UserID = Convert.ToInt32(fields[0]);
                    user.Designation = fields[1];
                    user.EmployeeID = Convert.ToInt32(fields[2]);
                    sReader.Close();
                    return user;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}
