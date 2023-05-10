using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Business;
using Library.Presentation;
using Library;

namespace Library
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }
        Books book = new Books();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAccountName_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveForm.Hide();
            FormAccount accountPage = new FormAccount();
            accountPage.Show();
        }

        private void lblAccountName_MouseHover(object sender, EventArgs e)
        {
            Font labelFont = new Font(lblAccountName.Font, FontStyle.Bold);
            lblAccountName.Font = labelFont;
        }

        private void FormMainMenu_MouseHover(object sender, EventArgs e)
        {
            Font labelFont = new Font(lblAccountName.Font, FontStyle.Regular);
            lblAccountName.Font = labelFont;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            lblAccountName.Text = FormLogin.user.Name;
            Logic context = new Logic();
            List<Books> bookList = context.GetList();
            foreach(Books b in bookList)
            {
                b.AverageRating = context.BookAvgRating(b);
            }
            dgvBooks.DataSource =bookList;
            dgvBooks.Columns.Remove("BookID");
            dgvBooks.Columns.Remove("Isbn");
            dgvBooks.Columns.Remove("UserRating");
            dgvBooks.RowHeadersVisible = false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormAddBooks addBooks = new FormAddBooks();
            addBooks.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Logic context = new Logic();
            
            List<Books> bookList = context.SearchInList(searchBox.Text, cmbCategory.Text);
            foreach (Books b in bookList)
            {
                b.AverageRating = context.BookAvgRating(b);
            }
            dgvBooks.DataSource = bookList;
            dgvBooks.Columns.Remove("BookID");
            dgvBooks.Columns.Remove("Isbn");
            dgvBooks.Columns.Remove("UserRating");
            dgvBooks.RowHeadersVisible = false;
        }

        private void dgvBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActiveForm.Hide();
            FormBookInfo formBookInfo = new FormBookInfo(book);
            formBookInfo.Show();
        }

        

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Logic logic = new Logic();
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                book = logic.Find(row.Cells[0].Value.ToString());
            }
        }

        private void btnQuickAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Logic logic = new Logic();
                logic.AddBookToUser(book, FormLogin.user);
                MessageBox.Show("The book was successfully added to your list");
            }
            catch
            {
                MessageBox.Show("The book is already added to your list");
            }
        }
    }
}
