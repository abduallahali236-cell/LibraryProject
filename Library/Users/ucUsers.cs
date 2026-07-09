using Library.Business;
using Library.Models;
using Library.Business.Global;
using Library.UI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Library.Models.User;
namespace Library.UI.Users;

public partial class ucUsers : UserControl
{
    private readonly UserService _userService = new();

    public ucUsers()
    {
        InitializeComponent();

        Authorization.EnsureAdmin();

        LoadUsers();
    }

private void LoadUsers()
    {
        dgvUsers.DataSource = _userService.GetAll();

        dgvUsers.ClearSelection();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string keyword = txtSearch.Text.Trim();

        dgvUsers.DataSource =
            _userService
            .GetAll()
            .Where(u =>
                u.Username.Contains(keyword,
                    StringComparison.OrdinalIgnoreCase)
                ||
                u.FullName.Contains(keyword,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();

        LoadUsers();
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        FrmUserDetails frm = new();

        if (frm.ShowDialog() == DialogResult.OK)
            LoadUsers();
    }
    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvUsers.CurrentRow == null)
            return;

        User user =
            (User)dgvUsers.CurrentRow.DataBoundItem;

        FrmUserDetails frm = new(user);

        if (frm.ShowDialog() == DialogResult.OK)
            LoadUsers();
    }
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvUsers.CurrentRow == null)
            return;

        User user =
            (User)dgvUsers.CurrentRow.DataBoundItem;

        if (!MessageHelper.Confirm(
            $"Delete '{user.Username}' ?"))
            return;
        try
        {
            _userService.Delete(user.UserId);
        }
        catch(Exception ex)
        {
            MessageHelper.Error(
                $"Error deleting user: {ex.Message}");
            return;
        }

        MessageHelper.Success(
            "User deleted successfully.");

        LoadUsers();
    }

}