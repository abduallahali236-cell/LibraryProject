namespace Library.UI.Users
{
    partial class FrmUserDetails
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
            label3 = new Label();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblFullName = new Label();
            cbShowPassword = new CheckBox();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(363, 79);
            label3.Name = "label3";
            label3.Size = new Size(88, 64);
            label3.TabIndex = 38;
            label3.Text = "Role  : ";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonHighlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnSave.ForeColor = Color.Black;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(477, 172);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 52);
            btnSave.TabIndex = 5;
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
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(12, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 52);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(440, 32);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(149, 95);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(157, 23);
            txtFullName.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(149, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(157, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(143, 64);
            label1.TabIndex = 35;
            label1.Text = "Username : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(8, 80);
            label2.Name = "label2";
            label2.Size = new Size(131, 64);
            label2.TabIndex = 36;
            label2.Text = "FullName :";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = SystemColors.ActiveCaptionText;
            lblFullName.Location = new Point(312, 16);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(139, 64);
            lblFullName.TabIndex = 37;
            lblFullName.Text = "Password  : ";
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(601, 34);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(55, 19);
            cbShowPassword.TabIndex = 39;
            cbShowPassword.Text = "Show";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(440, 95);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(157, 23);
            cmbRole.TabIndex = 4;
            // 
            // FrmUserDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(668, 236);
            Controls.Add(cmbRole);
            Controls.Add(cbShowPassword);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Name = "FrmUserDetails";
            Text = "FrmUserDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label lblFullName;
        private CheckBox cbShowPassword;
        private ComboBox cmbRole;
    }
}