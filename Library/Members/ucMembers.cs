using Library.Business;
using Library.Business.Global;
using Library.Models;
using Library.UI.Members;
using System;

namespace Library.UI.UserControls;

public partial class ucMembers : UserControl
{
    private readonly MemberService _memberService = new();

    public ucMembers()
    {
        InitializeComponent();

        ApplyPermissions();

        LoadMembers();
    }

    private void ApplyPermissions()
    {
        btnDelete.Visible = CurrentUser.IsAdmin;
    }

    private void LoadMembers()
    {
        dgvMembers.DataSource = _memberService.GetAll();

        dgvMembers.ClearSelection();
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
        dgvMembers.DataSource =
            _memberService.Search(txtSearch.Text.Trim());
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        FrmMemberDetails frm = new();

        if (frm.ShowDialog() == DialogResult.OK)
            LoadMembers();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvMembers.CurrentRow == null)
            return;


        if ((Member)dgvMembers.CurrentRow.DataBoundItem == null)
            return;

        Member member =
            (Member)dgvMembers.CurrentRow.DataBoundItem;

        FrmMemberDetails frm = new(member);

        if (frm.ShowDialog() == DialogResult.OK)
            LoadMembers();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvMembers.CurrentRow == null)
            return;


        if ((Member)dgvMembers.CurrentRow.DataBoundItem == null)
            return;

        Member member =
            (Member)dgvMembers.CurrentRow.DataBoundItem;

        if (!MessageHelper.Confirm(
            $"Delete '{member.FullName}' ?"))
            return;

        try
        {
            _memberService.Delete(member.MemberId);
        }
        catch(Exception ex)
        {
            MessageHelper.Error("An error occurred while deleting the member." + ex.Message);
            return;
        }

        MessageHelper.Success("Member deleted successfully.");

        LoadMembers();
    }
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();

        LoadMembers();
    }


}

