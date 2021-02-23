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
    public class ClientsDA
    {
        private static string filePath = Application.StartupPath + @"\Clients.dat";

        public static void Add(Clients client)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(client.ClientID + "," + client.Name + "," + client.Street + "," + client.City + "," + client.PostalCode + "," + client.PhoneNumber + "," + client.FaxNumber + "," + client.CreditLimit);
            sWriter.Close();
            MessageBox.Show("Client has been added to the list", "Confirmation");
        }

        public static void ListClients(ListView listViewClient)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewClient.Items.Clear();

            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                item.SubItems.Add(fields[4]);
                item.SubItems.Add(fields[5]);
                item.SubItems.Add(fields[6]);
                item.SubItems.Add(fields[7]);
                listViewClient.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static Clients Search(int clientID)
        {
            Clients client = new Clients();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (clientID == Convert.ToInt32(fields[0]))
                {
                    client.ClientID = Convert.ToInt32(fields[0]);
                    client.Name = fields[1];
                    client.Street = fields[2];
                    client.City = fields[3];
                    client.PostalCode = fields[4];
                    client.PhoneNumber = fields[5];
                    client.FaxNumber = fields[6];
                    client.CreditLimit = Convert.ToInt32(fields[7]);
                    sReader.Close();
                    return client;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}
