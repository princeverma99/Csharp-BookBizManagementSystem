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
    public partial class UserForm : Form
    {
        private void ClearAll()
        {
            tb_designation.Clear();
            tb_employee_id.Clear();
            tb_user_id.Clear();
        }

        public UserForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (UserValidation.isValidID(tb_user_id) && UserValidation.IsUniqueID(tb_user_id) &&UserValidation.isValidName(tb_designation) && UserValidation.isValidEmployee(tb_employee_id))
            {
                user.UserID = Convert.ToInt32(tb_user_id.Text);
                user.Designation = tb_designation.Text;
                user.EmployeeID = Convert.ToInt32(tb_employee_id.Text);
                UserDA.Add(user);
                ClearAll();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_search.Text))
            {
                MessageBox.Show("Please enter Employee ID", "Search not Possible");
            }
            else
            {
                User user = UserDA.Search(Convert.ToInt32(tb_search.Text));

                if (user != null)
                {
                    tb_user_id.Text = user.UserID.ToString();
                    tb_designation.Text = user.Designation;
                    tb_employee_id.Text = user.EmployeeID.ToString();
                    tb_search.Clear();
                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Search Failed");
                    tb_search.Clear();
                }
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            listView_user.Items.Clear();
            UserDA.ListUsers(listView_user);
        }
    }
}
