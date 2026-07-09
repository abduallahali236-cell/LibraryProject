namespace Library.UI.Borrowings
{
    partial class FrmBorrowBook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBorrow = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            cmbBooks = new ComboBox();
            label1 = new Label();
            lblFullName = new Label();
            cmbMembers = new ComboBox();
            dtpDueDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = SystemColors.ButtonHighlight;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnBorrow.ForeColor = Color.Black;
            btnBorrow.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            btnBorrow.IconColor = Color.Black;
            btnBorrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrow.Location = new Point(223, 208);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(140, 52);
            btnBorrow.TabIndex = 21;
            btnBorrow.Text = "Borrow";
            btnBorrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.ForeColor = Color.Black;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(21, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 52);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(63, 73);
            label4.Name = "label4";
            label4.Size = new Size(89, 64);
            label4.TabIndex = 27;
            label4.Text = "Book : ";
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(158, 87);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(205, 23);
            cmbBooks.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 64);
            label1.TabIndex = 23;
            label1.Text = "Member : ";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = SystemColors.ActiveCaptionText;
            lblFullName.Location = new Point(16, 137);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(136, 64);
            lblFullName.TabIndex = 26;
            lblFullName.Text = "Due Date  : ";
            // 
            // cmbMembers
            // 
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(158, 25);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(205, 23);
            cmbMembers.TabIndex = 1;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(158, 149);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(205, 23);
            dtpDueDate.TabIndex = 3;
            // 
            // FrmBorrowBook
            // 
            AcceptButton = btnBorrow;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(375, 289);
            Controls.Add(dtpDueDate);
            Controls.Add(cmbMembers);
            Controls.Add(btnBorrow);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(cmbBooks);
            Controls.Add(label1);
            Controls.Add(lblFullName);
            Name = "FrmBorrowBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBorrowBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudPublishYear;
        private FontAwesome.Sharp.IconButton btnBorrow;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Label label5;
        private NumericUpDown nudCopies;
        private Label label4;
        private ComboBox cmbBooks;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblFullName;
        private ComboBox cmbMembers;
        private DateTimePicker dtpDueDate;
    }
}