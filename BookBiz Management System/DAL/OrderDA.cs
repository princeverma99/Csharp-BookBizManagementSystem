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
    public class OrderDA
    {
        private static string filePath = Application.StartupPath + @"\Orders.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp-Orders.dat";

        public static void Add(Order order)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(order.OrderID + "," + order.ClientID + "," + order.BookID + "," + order.Quantity);
            sWriter.Close();
            MessageBox.Show("Order has been added to the list", "Confirmation");
        }

        public static void ListOrders(ListView listViewOrders)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewOrders.Items.Clear();

            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                listViewOrders.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static Order Search(int orderID)
        {
            Order order = new Order();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (orderID == Convert.ToInt32(fields[0]))
                {
                    order.OrderID = Convert.ToInt32(fields[0]);
                    order.ClientID = Convert.ToInt32(fields[1]);
                    order.BookID = Convert.ToInt64(fields[2]);
                    order.Quantity = Convert.ToInt32(fields[3]);
                    sReader.Close();
                    return order;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }

        public static bool Cancel(int orderID)
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            int flag = 0;

            StreamWriter sWriter = new StreamWriter(fileTemp, true);

            while (line != null)
            {
                string[] fields = line.Split(',');

                if ((orderID) != Convert.ToInt32(fields[0]))
                {
                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);
                }
                else
                {
                    flag = 1;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            sWriter.Close();

            File.Delete(filePath);
            File.Move(fileTemp, filePath);
            if (flag == 0)
            {
                MessageBox.Show("Order Data not found", "Failed to Cancel");
                return false;
            }
            else
            {
                MessageBox.Show("Order Data has been Cancelled Successfully", "Success");
                return true;
            }
        }  
    }
}
