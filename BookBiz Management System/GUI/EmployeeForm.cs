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
    public partial class EmployeeForm : Form
    {
        private void ClearAll()
        {
            tb_employee_id.Clear();
            tb_name.Clear();
            maskedTextBox_phone_no.Clear();
        }

        public EmployeeForm()
        {
            InitializeComponent();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (EmployeeValidation.isValidID(tb_employee_id) && EmployeeValidation.IsUniqueID(tb_employee_id) && EmployeeValidation.isValidName(tb_name))
            {
                emp.EmployeeID = Convert.ToInt32(tb_employee_id.Text);
                emp.Name = tb_name.Text;
                emp.PhoneNumber = maskedTextBox_phone_no.Text;
                EmployeeDA.Add(emp);
                ClearAll();
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            listView_employee.Items.Clear();
            EmployeeDA.ListEmployee(listView_employee);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_search.Text))
            {
                MessageBox.Show("Please enter Employee ID", "Search not Possible");
            }
            else
            {
                Employee emp = EmployeeDA.Search(Convert.ToInt32(tb_search.Text));

                if (emp != null)
                {
                    tb_employee_id.Text = emp.EmployeeID.ToString();
                    tb_name.Text = emp.Name;
                    maskedTextBox_phone_no.Text = emp.PhoneNumber;
                    tb_search.Clear();
                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Search Failed");
                    tb_search.Clear();
                }
            }
        }
    }
}
