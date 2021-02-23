using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz_Management_System.DAL;

namespace BookBiz_Management_System.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int choice= comboBox_login.SelectedIndex;
            switch(choice)
            {
                case -1: MessageBox.Show("Please Choose from above options","User not Selected");
                    break;
                case 0: this.Hide();
                    MISManagerLogin mgrlogin = new MISManagerLogin();
                    mgrlogin.ShowDialog();
                    this.Close();

                    break;
                case 1:
                    this.Hide();
                    ClientsForm clientform = new ClientsForm();
                    clientform.ShowDialog();
                    this.Close();
                    break;
                case 2: this.Hide();
                    BookForm bookform = new BookForm();
                    bookform.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    this.Hide();
                    OrderForm orderform = new OrderForm();
                    orderform.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to Exit?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
