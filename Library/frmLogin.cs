using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library.Business;
using Library.Business.Global;
using Library.Models;

namespace Library.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
             
            try
            {
                User? user = userService.Login(username, password);
                if (user == null)
                {
                    MessageHelper.Error("Invalid username or password.");
                    return;
                }
                CurrentUser.Login(user);
                this.Hide();               
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageHelper.Error($"An error occurred while logging in: {ex.Message}");
                return;
            }

           
        }
    }
}

