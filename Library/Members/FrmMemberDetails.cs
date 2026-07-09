using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library.Models;
using Library.Business;

namespace Library.UI.Members
{
    public partial class FrmMemberDetails : Form
    {

        private readonly MemberService _memberService = new();

        private readonly bool _isEdit;

        private Member _member;

        public FrmMemberDetails()
        {
            InitializeComponent();

            _member = new Member();

            Text = "Add Member";

            btnSave.Enabled = false;
        }

        public FrmMemberDetails(Member member)
        {
            InitializeComponent();

            _member = member;

            _isEdit = true;

            FillControls();

            Text = "Edit Member";
        }

        private void FillControls()
        {
            txtFullName.Text = _member.FullName;

            txtPhone.Text = _member.Phone;

            txtEmail.Text = _member.Email;

            txtAddress.Text = _member.Address;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            _member.FullName = txtFullName.Text.Trim();

            _member.Phone = txtPhone.Text.Trim();

            _member.Email = txtEmail.Text.Trim();

            _member.Address = txtAddress.Text.Trim();

            try
            {
                if (_isEdit)
                    _memberService.Update(_member);
                else
                    _memberService.Add(_member);
            }
            catch(Exception ex)
            {
                MessageHelper.Error("An error occurred while saving the member: " + ex.Message);
            }

            DialogResult = DialogResult.OK;

            Close();
        }


private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if(sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider1.SetError(textBox, "This field is required.");
                    btnSave.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(textBox, string.Empty);
                    btnSave.Enabled = true;
                }
            }


        }
    }
}
