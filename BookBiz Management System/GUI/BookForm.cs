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
    public partial class BookForm : Form
    {
        private void ClearAll()
        {
            tb_isbn.Clear();
            tb_quantity_on_hand.Clear();
            tb_title.Clear();
            tb_unit_price.Clear();
            tb_year_published.Clear();
        }

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_to_list_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            if (BookValidation.isValidISBN(tb_isbn) && BookValidation.IsUniqueID(tb_isbn) &&BookValidation.isValidName(tb_title) && BookValidation.isValidValues(tb_unit_price) && BookValidation.isValidYear(tb_year_published) && BookValidation.isValidValues(tb_quantity_on_hand))
            {
                book.ISBN = Convert.ToInt64(tb_isbn.Text);
                book.Title = tb_title.Text;
                book.UnitPrice = Convert.ToInt32(tb_unit_price.Text);
                book.YearPublished = Convert.ToInt32(tb_year_published.Text);
                book.QOH = Convert.ToInt32(tb_quantity_on_hand.Text);
                BookDA.Add(book);
                ClearAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView_book.Items.Clear();
            BookDA.ListBook(listView_book);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_search.Text))
            {
                MessageBox.Show("Please enter ISBN", "Search not Possible");
            }
            else
            {
                Books book = BookDA.Search(Convert.ToInt64(tb_search.Text));

                if (book != null)
                {
                    tb_isbn.Text = book.ISBN.ToString();
                    tb_title.Text = book.Title;
                    tb_unit_price.Text = book.UnitPrice.ToString();
                    tb_year_published.Text = book.YearPublished.ToString();
                    tb_quantity_on_hand.Text = book.QOH.ToString();
                    tb_search.Clear();
                }
                else
                {
                    MessageBox.Show("Book Not Found", "Search Failed");
                    tb_search.Clear();
                }
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
    }
}
