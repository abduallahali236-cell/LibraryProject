using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library.Models;
using Library.Business;
using Library.Business.Global;
using Library.UI;

namespace Library.UI.Users
{
    public partial class FrmUserDetails : Form
    {
        private readonly UserService _userService = new();

        private readonly bool _isEdit;

        private User _user;
        public FrmUserDetails()
        {
            InitializeComponent();

            _user = new User();

            LoadRoles();

            Text = "Add User";
        }
        public FrmUserDetails(User user)
        {
            InitializeComponent();

            _user = user;

            _isEdit = true;

            LoadRoles();

            FillControls();

            Text = "Edit User";
        }
        private void LoadRoles()
        {
            cmbRole.DataSource =
                Enum.GetValues<User.UserRole>();
        }
        private void FillControls()
        {
            txtUsername.Text = _user.Username;
            txtUsername.Enabled = false;

            txtPassword.Text = "";

            txtFullName.Text = _user.FullName;

            cmbRole.SelectedItem = _user.Role;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.Username = txtUsername.Text.Trim();

            _user.Password = txtPassword.Text.Trim();

            _user.FullName = txtFullName.Text.Trim();

            _user.Role = (User.UserRole)cmbRole.SelectedItem!;

            try
            {
                if (_isEdit)
                    _userService.Update(_user);
                else
                    _userService.Add(_user);
            }
            catch (Exception ex)
            {
                MessageHelper.Error("an error occurred while saving the user: " + ex.Message);
            }


            DialogResult = DialogResult.OK;

            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
