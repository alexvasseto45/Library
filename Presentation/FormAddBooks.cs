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


namespace Library
{
    public partial class FormAddBooks : Form
    {
        public FormAddBooks()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Logic addBook = new Logic();
            addBook.AddBook(txtName.Text, txtISBN.Text, txtAuthor.Text, cmbGenre.Text);
            ActiveForm.Hide();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
            MessageBox.Show("Successfully added a new book!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }

        private void txtName_MouseClick(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Clear();
            }
        }
        private void txtISBN_MouseClick(object sender, EventArgs e)
        {
            if (txtISBN.Text == "ISBN")
            {
                txtISBN.Clear();
            }
        }
        private void txtAuthor_MouseClick(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "Author")
            {
                txtAuthor.Clear();
            }
        }

    }
}
