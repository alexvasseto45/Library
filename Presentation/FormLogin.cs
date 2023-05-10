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

namespace Library
{
    public partial class FormLogin : Form
    {
        public static Users user = new Users();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logic login = new Logic();
            if (login.Login(txtUsername.Text, txtPassword.Text) == true)
            {
                user = login.FindUser(txtUsername.Text, txtPassword.Text);
                ActiveForm.Hide();
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormSignUp signup = new FormSignUp();
            signup.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
