namespace Library.UI.Borrowings
{
    partial class ucBorrowings
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
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnReturn = new FontAwesome.Sharp.IconButton();
            btnBorrow = new FontAwesome.Sharp.IconButton();
            dgvBorrowings = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Desktop;
            btnSearch.Dock = DockStyle.Bottom;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnSearch.ForeColor = Color.CornflowerBlue;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.LightGray;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 40;
            btnSearch.Location = new Point(0, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(803, 46);
            btnSearch.TabIndex = 27;
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
            txtSearch.TabIndex = 26;
            txtSearch.TextChanged += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Desktop;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnRefresh.ForeColor = Color.CornflowerBlue;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.LightGray;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(322, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(158, 52);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.Desktop;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnReturn.ForeColor = Color.CornflowerBlue;
            btnReturn.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnReturn.IconColor = Color.LightGray;
            btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReturn.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturn.Location = new Point(642, 1);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(158, 52);
            btnReturn.TabIndex = 24;
            btnReturn.Text = "Return";
            btnReturn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturnBook_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = SystemColors.Desktop;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnBorrow.ForeColor = Color.CornflowerBlue;
            btnBorrow.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            btnBorrow.IconColor = Color.LightGray;
            btnBorrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrow.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrow.Location = new Point(483, 1);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(158, 52);
            btnBorrow.TabIndex = 23;
            btnBorrow.Text = "Borrow";
            btnBorrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrowBook_Click;
            // 
            // dgvBorrowings
            // 
            dgvBorrowings.AllowUserToAddRows = false;
            dgvBorrowings.AllowUserToDeleteRows = false;
            dgvBorrowings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowings.Dock = DockStyle.Bottom;
            dgvBorrowings.Location = new Point(0, 130);
            dgvBorrowings.Name = "dgvBorrowings";
            dgvBorrowings.ReadOnly = true;
            dgvBorrowings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowings.Size = new Size(803, 319);
            dgvBorrowings.TabIndex = 22;
            // 
            // ucBorrowings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dgvBorrowings);
            Name = "ucBorrowings";
            Size = new Size(803, 449);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnBorrow;
        private DataGridView dgvBorrowings;
    }
}
