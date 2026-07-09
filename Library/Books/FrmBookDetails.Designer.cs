using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using FontAwesome.Sharp;

namespace Library.UI.Books
{
    partial class FrmBookDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Initializes designer controls
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            label2 = new Label();
            lblFullName = new Label();
            label1 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            cmbCategory = new ComboBox();
            label4 = new Label();
            nudCopies = new NumericUpDown();
            label5 = new Label();
            btnSave = new IconButton();
            btnCancel = new IconButton();
            errorProvider1 = new ErrorProvider(components);
            nudPublishYear = new NumericUpDown();
            ((ISupportInitialize)nudCopies).BeginInit();
            ((ISupportInitialize)errorProvider1).BeginInit();
            ((ISupportInitialize)nudPublishYear).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(-3, 73);
            label2.Name = "label2";
            label2.Size = new Size(105, 64);
            label2.TabIndex = 10;
            label2.Text = "Author :";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = SystemColors.ActiveCaptionText;
            lblFullName.Location = new Point(11, 137);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 64);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "ISBN  : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 64);
            label1.TabIndex = 10;
            label1.Text = "Title : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(271, 73);
            label3.Name = "label3";
            label3.Size = new Size(158, 64);
            label3.TabIndex = 10;
            label3.Text = "Publish year :";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(108, 24);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(157, 23);
            txtTitle.TabIndex = 1;
            txtTitle.Leave += txtBox_Leave;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(108, 88);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(157, 23);
            txtAuthor.TabIndex = 2;
            txtAuthor.Leave += txtBox_Leave;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(108, 152);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(157, 23);
            txtISBN.TabIndex = 3;
            txtISBN.Leave += txtBox_Leave;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Programming", "Database", "Science", "History", "Novels" });
            cmbCategory.Location = new Point(435, 25);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(137, 23);
            cmbCategory.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(298, 9);
            label4.Name = "label4";
            label4.Size = new Size(131, 64);
            label4.TabIndex = 12;
            label4.Text = "Category : ";
            // 
            // nudCopies
            // 
            nudCopies.Location = new Point(435, 151);
            nudCopies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCopies.Name = "nudCopies";
            nudCopies.Size = new Size(137, 23);
            nudCopies.TabIndex = 6;
            nudCopies.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(322, 137);
            label5.Name = "label5";
            label5.Size = new Size(107, 64);
            label5.TabIndex = 14;
            label5.Text = "Copies : ";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonHighlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnSave.ForeColor = Color.Black;
            btnSave.IconChar = IconChar.Save;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = IconFont.Auto;
            btnSave.Location = new Point(452, 206);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 52);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.ForeColor = Color.Black;
            btnCancel.IconChar = IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = IconFont.Auto;
            btnCancel.Location = new Point(11, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 52);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // nudPublishYear
            // 
            nudPublishYear.Location = new Point(435, 88);
            nudPublishYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudPublishYear.Minimum = new decimal(new int[] { 1450, 0, 0, 0 });
            nudPublishYear.Name = "nudPublishYear";
            nudPublishYear.Size = new Size(137, 23);
            nudPublishYear.TabIndex = 15;
            nudPublishYear.Value = new decimal(new int[] { 1450, 0, 0, 0 });
            // 
            // FrmBookDetails
            // 
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            ClientSize = new Size(584, 270);
            Controls.Add(nudPublishYear);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(nudCopies);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBookDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Book Details";
            ((ISupportInitialize)nudCopies).EndInit();
            ((ISupportInitialize)errorProvider1).EndInit();
            ((ISupportInitialize)nudPublishYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label lblFullName;
        private Label label1;
        private Label label3;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private ComboBox cmbCategory;
        private Label label4;
        private NumericUpDown nudCopies;
        private Label label5;
        private IconButton btnSave;
        private IconButton btnCancel;
        private TextBox txtTitle;
        private ErrorProvider errorProvider1;
        private NumericUpDown nudPublishYear;
    }
}
