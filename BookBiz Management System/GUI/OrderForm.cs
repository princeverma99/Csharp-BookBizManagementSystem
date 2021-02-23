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
    public partial class OrderForm : Form
    {
        List<Order> listC = new List<Order>();
        private void ClearAll()
        {
            tb_book_id.Clear();
            tb_client_id.Clear();
            tb_order_id.Clear();
            tb_quantity.Clear();
        }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to Exit?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            if (OrderValidation.isValidID(tb_order_id) && OrderValidation.IsUniqueID(tb_order_id) && OrderValidation.isValidClient(tb_client_id) && OrderValidation.isValidBooks(tb_book_id) && OrderValidation.isValidValues(tb_quantity))
            {
                order.OrderID = Convert.ToInt32(tb_order_id.Text);
                order.ClientID = Convert.ToInt32(tb_client_id.Text);
                order.BookID = Convert.ToInt64(tb_book_id.Text);
                order.Quantity = Convert.ToInt32(tb_quantity.Text);
                OrderDA.Add(order);
                ClearAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            listView_orders.Items.Clear();
            OrderDA.ListOrders(listView_orders);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_search.Text))
            {
                MessageBox.Show("Please enter Order ID", "Search not Possible");
            }
            else
            {
                Order order = OrderDA.Search(Convert.ToInt32(tb_search.Text));

                if (order != null)
                {
                    tb_order_id.Text = order.ClientID.ToString();
                    tb_client_id.Text = order.ClientID.ToString();
                    tb_book_id.Text = order.BookID.ToString();
                    tb_quantity.Text = order.Quantity.ToString();
                    tb_search.Clear();
                }
                else
                {
                    MessageBox.Show("Order Not Found", "Search Failed");
                    tb_search.Clear();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (OrderValidation.isValidID(tb_search))
            {
                if (OrderDA.Cancel(Convert.ToInt32(tb_search.Text)))
                {
                    ClearAll();
                    listView_orders.Items.Clear();
                    OrderDA.ListOrders(listView_orders);
                }
            }
            ClearAll();
        }
    }
}
