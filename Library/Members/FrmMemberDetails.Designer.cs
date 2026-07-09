namespace Library.UI.Members
{
    partial class FrmMemberDetails
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
            components = new System.ComponentModel.Container();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblFullName = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
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
            btnSave.Location = new Point(288, 290);
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
            btnCancel.Location = new Point(12, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 52);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 23);
            txtEmail.TabIndex = 3;
            txtEmail.Leave += TextBox_Leave;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(200, 87);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(157, 23);
            txtPhone.TabIndex = 2;
            txtPhone.Leave += TextBox_Leave;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(200, 24);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(157, 23);
            txtFullName.TabIndex = 1;
            txtFullName.Leave += TextBox_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(59, 8);
            label1.Name = "label1";
            label1.Size = new Size(135, 64);
            label1.TabIndex = 23;
            label1.Text = "FullName : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(95, 72);
            label2.Name = "label2";
            label2.Size = new Size(99, 64);
            label2.TabIndex = 25;
            label2.Text = "Phone :";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = SystemColors.ActiveCaptionText;
            lblFullName.Location = new Point(94, 136);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 64);
            lblFullName.TabIndex = 26;
            lblFullName.Text = "Email  : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(200, 213);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(157, 23);
            txtAddress.TabIndex = 4;
            txtAddress.Leave += TextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(69, 200);
            label3.Name = "label3";
            label3.Size = new Size(125, 64);
            label3.TabIndex = 28;
            label3.Text = "Address  : ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmMemberDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(420, 354);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMemberDetails";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label1;
        private Label label2;
        private Label lblFullName;
        private TextBox txtAddress;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}