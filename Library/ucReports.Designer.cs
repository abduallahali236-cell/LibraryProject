using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Library.UI.UserControls
{
    partial class ucReports : UserControl
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
            btnExportExcel = new FontAwesome.Sharp.IconButton();
            btnExportPdf = new FontAwesome.Sharp.IconButton();
            dgvReports = new DataGridView();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            lblRows = new Label();
            lblLastUpdated = new Label();
            label1 = new Label();
            cmbReportType = new ComboBox();
            ((ISupportInitialize)dgvReports).BeginInit();
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
            btnSearch.Location = new Point(0, 178);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(868, 46);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += txtSearch_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Location = new Point(0, 224);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(868, 23);
            txtSearch.TabIndex = 32;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = SystemColors.Desktop;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnExportExcel.ForeColor = Color.CornflowerBlue;
            btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btnExportExcel.IconColor = Color.LightGray;
            btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(682, 1);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(208, 52);
            btnExportExcel.TabIndex = 30;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = SystemColors.Desktop;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnExportPdf.ForeColor = Color.CornflowerBlue;
            btnExportPdf.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnExportPdf.IconColor = Color.LightGray;
            btnExportPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportPdf.Location = new Point(484, 1);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(193, 52);
            btnExportPdf.TabIndex = 29;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Dock = DockStyle.Bottom;
            dgvReports.Location = new Point(0, 247);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(868, 319);
            dgvReports.TabIndex = 28;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(105, 124);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(205, 23);
            dtpTo.TabIndex = 34;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTo.ForeColor = SystemColors.ActiveCaptionText;
            lblTo.Location = new Point(31, 111);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(68, 64);
            lblTo.TabIndex = 35;
            lblTo.Text = "To  : ";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(105, 70);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(205, 23);
            dtpFrom.TabIndex = 36;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrom.ForeColor = SystemColors.ActiveCaptionText;
            lblFrom.Location = new Point(3, 57);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(96, 64);
            lblFrom.TabIndex = 37;
            lblFrom.Text = "From  : ";
            // 
            // lblRows
            // 
            lblRows.AutoSize = true;
            lblRows.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRows.ForeColor = SystemColors.ActiveCaptionText;
            lblRows.Location = new Point(322, 111);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(39, 64);
            lblRows.TabIndex = 39;
            lblRows.Text = "0";
            // 
            // lblLastUpdated
            // 
            lblLastUpdated.AutoSize = true;
            lblLastUpdated.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastUpdated.ForeColor = SystemColors.ActiveCaptionText;
            lblLastUpdated.Location = new Point(609, 111);
            lblLastUpdated.Name = "lblLastUpdated";
            lblLastUpdated.Size = new Size(39, 64);
            lblLastUpdated.TabIndex = 38;
            lblLastUpdated.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(164, 64);
            label1.TabIndex = 40;
            label1.Text = "Report Type  : ";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(173, 20);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(137, 23);
            cmbReportType.TabIndex = 41;
            // 
            // ucReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbReportType);
            Controls.Add(label1);
            Controls.Add(lblRows);
            Controls.Add(lblLastUpdated);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExportPdf);
            Controls.Add(dgvReports);
            Name = "ucReports";
            Size = new Size(868, 566);
            ((ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private FontAwesome.Sharp.IconButton btnExportPdf;
        private DataGridView dgvReports;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpFrom;
        private Label lblFrom;
        private Label lblRows;
        private Label lblLastUpdated;
        private Label label1;
        private ComboBox cmbReportType;
    }
}
