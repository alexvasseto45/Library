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
using Library.Data.Models;

namespace Library.Presentation
{
    public partial class FormBookInfo : Form
    {
        private Books book = new Books();
        Logic logic = new Logic();

        public FormBookInfo(Books book)
        {
            this.book = book;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }

        private void FormBookInfo_Load(object sender, EventArgs e)
        {
            rbRating1.TabStop = false;
            rbRating2.TabStop = false;
            rbRating3.TabStop = false;
            rbRating4.TabStop = false;
            rbRating5.TabStop = false;
            lblName.Text = book.Name;
            lblAuthor.Text = book.Author;
            lblISBN.Text = book.Isbn;
            lblCategory.Text = book.Category;
            if (logic.IsBookAdded(FormLogin.user, book))
            {
                btnAddToList.Visible = false;
                btnRemoveFromList.Visible = true;
            }
            else
            {
                btnAddToList.Visible = true;
                btnRemoveFromList.Visible = false;
            }
        }


        private void btnAddToList_Click(object sender, EventArgs e)
        {
            logic.AddBookToUser(book, FormLogin.user);
            btnRemoveFromList.Visible = true;
            btnAddToList.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }

        private void rbRating1_CheckedChanged(object sender, EventArgs e)
        {
            if(logic.IsBookAdded(FormLogin.user, book) == false && rbRating1.Checked == true)
            {
                MessageBox.Show("You cannot rate the book unless it's in your list!");
            }
            else
            {
                logic.AddRating(book, FormLogin.user, 1);
            }
        }

        private void rbRating2_CheckedChanged(object sender, EventArgs e)
        {
            if (logic.IsBookAdded(FormLogin.user, book) == false && rbRating2.Checked == true)
            {
                MessageBox.Show("You cannot rate the book unless it's in your list!");
            }
            else
            {
                logic.AddRating(book, FormLogin.user, 2);
            }
        }

        private void rbRating3_CheckedChanged(object sender, EventArgs e)
        {
           if (logic.IsBookAdded(FormLogin.user, book) == false && rbRating3.Checked == true)
            {
                MessageBox.Show("You cannot rate the book unless it's in your list!");
            }
            else
            {
                logic.AddRating(book, FormLogin.user, 3);
            }
        }

        private void rbRating4_CheckedChanged(object sender, EventArgs e)
        {
            if (logic.IsBookAdded(FormLogin.user, book) == false && rbRating4.Checked == true)
            {
                MessageBox.Show("You cannot rate the book unless it's in your list!");
            }
            else
            {
                logic.AddRating(book, FormLogin.user, 4);
            }
        }

        private void rbRating5_CheckedChanged(object sender, EventArgs e)
        {
            if (logic.IsBookAdded(FormLogin.user, book) == false && rbRating5.Checked == true)
            {
                MessageBox.Show("You cannot rate the book unless it's in your list!");
            }
            else
            {
                logic.AddRating(book, FormLogin.user, 5);
            }
        }

        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            logic.DeleteBookFromUser(book, FormLogin.user);
            btnRemoveFromList.Visible = false;
            btnAddToList.Visible = true;

        }
    }
}
