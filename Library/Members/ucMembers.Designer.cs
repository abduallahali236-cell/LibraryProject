using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Library.UI.UserControls
{
    partial class ucMembers : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearch = new IconButton();
            txtSearch = new TextBox();
            btnRefresh = new IconButton();
            btnDelete = new IconButton();
            btnEdit = new IconButton();
            btnAdd = new IconButton();
            dgvMembers = new DataGridView();
            ((ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Desktop;
            btnSearch.Dock = DockStyle.Bottom;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnSearch.ForeColor = Color.CornflowerBlue;
            btnSearch.IconChar = IconChar.Search;
            btnSearch.IconColor = Color.LightGray;
            btnSearch.IconFont = IconFont.Auto;
            btnSearch.IconSize = 40;
            btnSearch.Location = new Point(0, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(803, 46);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Location = new Point(0, 107);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(803, 23);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Desktop;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnRefresh.ForeColor = Color.CornflowerBlue;
            btnRefresh.IconChar = IconChar.Refresh;
            btnRefresh.IconColor = Color.LightGray;
            btnRefresh.IconFont = IconFont.Auto;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(322, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(158, 52);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Desktop;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.ForeColor = Color.CornflowerBlue;
            btnDelete.IconChar = IconChar.DeleteLeft;
            btnDelete.IconColor = Color.LightGray;
            btnDelete.IconFont = IconFont.Auto;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(802, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 52);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Desktop;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.ForeColor = Color.CornflowerBlue;
            btnEdit.IconChar = IconChar.Edit;
            btnEdit.IconColor = Color.LightGray;
            btnEdit.IconFont = IconFont.Auto;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(642, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 52);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Desktop;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.ForeColor = Color.CornflowerBlue;
            btnAdd.IconChar = IconChar.UserPlus;
            btnAdd.IconColor = Color.LightGray;
            btnAdd.IconFont = IconFont.Auto;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(482, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 52);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Dock = DockStyle.Bottom;
            dgvMembers.Location = new Point(0, 130);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(803, 319);
            dgvMembers.TabIndex = 8;
            // 
            // ucMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvMembers);
            Name = "ucMembers";
            Size = new Size(803, 449);
            ((ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private DataGridView dgvMembers;
    }
}
