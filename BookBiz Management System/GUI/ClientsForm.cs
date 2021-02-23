using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using BookBiz_Management_System.Validation;

namespace BookBiz_Management_System.GUI
{
    public partial class ClientsForm : Form
    {
        private void ClearAll()
        {
            textBox_client_id.Clear();
            textBox_client_name.Clear();
            textBox_street.Clear();
            textBox_city.Clear();
            textBox_postal_code.Clear();
            maskedTextBox_phone_no.Clear();
            textBox_fax_number.Clear();
            textBox_credit_limit.Clear();
        }

        public ClientsForm()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void button_add_to_list_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            if (ClientsValidation.isValidID(textBox_client_id) && ClientsValidation.IsUniqueID(textBox_client_id) &&ClientsValidation.isValidName(textBox_client_name) && ClientsValidation.isValidValues(textBox_street) && ClientsValidation.isValidValues(textBox_city) && ClientsValidation.isValidValues(textBox_postal_code) && ClientsValidation.isValidValues(textBox_fax_number) && ClientsValidation.isValidValues(textBox_credit_limit))
            {
                client.ClientID = Convert.ToInt32(textBox_client_id.Text);
                client.Name = textBox_client_name.Text;
                client.Street = textBox_street.Text;
                client.City = textBox_city.Text;
                client.PostalCode = textBox_postal_code.Text;
                client.PhoneNumber = maskedTextBox_phone_no.Text;
                client.FaxNumber = textBox_fax_number.Text;
                client.CreditLimit = Convert.ToInt32(textBox_credit_limit.Text);
                ClientsDA.Add(client);
                ClearAll();
            }
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            listView_clients.Items.Clear();
            ClientsDA.ListClients(listView_clients);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_search.Text))
            {
                MessageBox.Show("Please enter Client ID", "Search not Possible");
            }
            else
            {
                Clients client = ClientsDA.Search(Convert.ToInt32(textBox_search.Text));

                if (client != null)
                {
                    textBox_client_id.Text = client.ClientID.ToString();
                    textBox_client_name.Text = client.Name;
                    textBox_street.Text = client.Street;
                    textBox_city.Text = client.City;
                    textBox_postal_code.Text = client.PostalCode;
                    maskedTextBox_phone_no.Text = client.PhoneNumber;
                    textBox_fax_number.Text = client.FaxNumber;
                    textBox_credit_limit.Text = client.CreditLimit.ToString();
                    textBox_search.Clear();
                }
                else
                {
                    MessageBox.Show("Client Not Found", "Search Failed");
                    textBox_search.Clear();
                }
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to Exit?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
