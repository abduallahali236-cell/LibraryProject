using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Library.UI.Books
{
    partial class ucBooks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            dgvBooks = new DataGridView();
            btnAdd = new IconButton();
            btnEdit = new IconButton();
            btnDelete = new IconButton();
            btnRefresh = new IconButton();
            txtSearch = new TextBox();
            btnSearch = new IconButton();
            ((ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Dock = DockStyle.Bottom;
            dgvBooks.Location = new Point(0, 136);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(803, 313);
            dgvBooks.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Desktop;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.ForeColor = Color.CornflowerBlue;
            btnAdd.IconChar = IconChar.Add;
            btnAdd.IconColor = Color.LightGray;
            btnAdd.IconFont = IconFont.Auto;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(482, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 55);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            btnEdit.Size = new Size(158, 55);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            btnDelete.Size = new Size(158, 55);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnRefresh.Size = new Size(158, 55);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Location = new Point(0, 113);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(803, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += btnSearch_Click;
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
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(0, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(803, 51);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ucBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvBooks);
            Name = "ucBooks";
            Size = new Size(803, 449);
            ((ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private IconButton btnAdd;
        private IconButton btnEdit;
        private IconButton btnDelete;
        private IconButton btnRefresh;
        private TextBox txtSearch;
        private IconButton btnSearch;
    }
}
