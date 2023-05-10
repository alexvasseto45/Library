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
using Library.Presentation;

namespace Library
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }
        Books book = new Books();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            lblAccountName.Text = "Welcome, " + FormLogin.user.Name;
            Logic context = new Logic();
            
            dgvMyBooks.DataSource = context.SelectBookForUser(FormLogin.user);
            dgvMyBooks.Columns.Remove("BookID");
            dgvMyBooks.Columns.Remove("Isbn");
            dgvMyBooks.Columns.Remove("AverageRating");
            
        }

        private void dgvMyBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Logic logic = new Logic();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMyBooks.Rows[e.RowIndex];
                book = logic.Find(row.Cells[0].Value.ToString());
            }
        }

        private void dgvMyBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActiveForm.Hide();
            FormBookInfo formBookInfo = new FormBookInfo(book);
            formBookInfo.Show();
        }

        private void dgvMyBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Logic logic = new Logic();
            if (e.RowIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridViewRow row = dgvMyBooks.Rows[e.RowIndex];
                cmsRemove.Show(Cursor.Position);
                book = logic.Find(row.Cells[0].Value.ToString());
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic context = new Logic();
            context.DeleteBookFromUser(book, FormLogin.user);
            dgvMyBooks.DataSource = context.SelectBookForUser(FormLogin.user);
            dgvMyBooks.Columns.Remove("BookID");
            dgvMyBooks.Columns.Remove("Isbn");
            dgvMyBooks.Columns.Remove("AverageRating");
        }
    }
}
