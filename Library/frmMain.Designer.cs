namespace Library
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSideBar = new Panel();
            btnAbout = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnCategories = new FontAwesome.Sharp.IconButton();
            btnBorrowing = new FontAwesome.Sharp.IconButton();
            btnMembers = new FontAwesome.Sharp.IconButton();
            btnBooks = new FontAwesome.Sharp.IconButton();
            btnDashBoard = new FontAwesome.Sharp.IconButton();
            pnlContent = new Panel();
            pnlBottom = new Panel();
            lblRole = new Label();
            label2 = new Label();
            lblFullName = new Label();
            label5 = new Label();
            pnlTop = new Panel();
            label1 = new Label();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            pnlBottom.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlSideBar.BackgroundImageLayout = ImageLayout.Center;
            pnlSideBar.BorderStyle = BorderStyle.FixedSingle;
            pnlSideBar.Controls.Add(btnAbout);
            pnlSideBar.Controls.Add(btnReports);
            pnlSideBar.Controls.Add(iconPictureBox1);
            pnlSideBar.Controls.Add(btnLogout);
            pnlSideBar.Controls.Add(btnUsers);
            pnlSideBar.Controls.Add(btnCategories);
            pnlSideBar.Controls.Add(btnBorrowing);
            pnlSideBar.Controls.Add(btnMembers);
            pnlSideBar.Controls.Add(btnBooks);
            pnlSideBar.Controls.Add(btnDashBoard);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(0, 5, 0, 0);
            pnlSideBar.Size = new Size(154, 605);
            pnlSideBar.TabIndex = 1;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = SystemColors.Desktop;
            btnAbout.Dock = DockStyle.Bottom;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnAbout.ForeColor = Color.CornflowerBlue;
            btnAbout.IconChar = FontAwesome.Sharp.IconChar.Info;
            btnAbout.IconColor = Color.LightGray;
            btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbout.IconSize = 30;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 482);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(152, 58);
            btnAbout.TabIndex = 9;
            btnAbout.Text = "About";
            btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.Desktop;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnReports.ForeColor = Color.CornflowerBlue;
            btnReports.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            btnReports.IconColor = Color.LightGray;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.IconSize = 30;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(-2, 296);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(154, 52);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ActiveBorder;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            iconPictureBox1.Dock = DockStyle.Top;
            iconPictureBox1.ForeColor = Color.AliceBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            iconPictureBox1.IconColor = Color.AliceBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 85;
            iconPictureBox1.InitialImage = null;
            iconPictureBox1.Location = new Point(0, 5);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(152, 85);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnLogout.ForeColor = Color.Silver;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnLogout.IconColor = Color.LightGray;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 30;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 540);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 63);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = SystemColors.Desktop;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnUsers.ForeColor = Color.CornflowerBlue;
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsers.IconColor = Color.LightGray;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.IconSize = 30;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(-2, 400);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(154, 52);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "Users";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.Desktop;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnCategories.ForeColor = Color.CornflowerBlue;
            btnCategories.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnCategories.IconColor = Color.LightGray;
            btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategories.IconSize = 30;
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(-2, 348);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(154, 52);
            btnCategories.TabIndex = 4;
            btnCategories.Text = "Categories";
            btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnBorrowing
            // 
            btnBorrowing.BackColor = SystemColors.Desktop;
            btnBorrowing.FlatStyle = FlatStyle.Flat;
            btnBorrowing.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnBorrowing.ForeColor = Color.CornflowerBlue;
            btnBorrowing.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnBorrowing.IconColor = Color.LightGray;
            btnBorrowing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrowing.IconSize = 30;
            btnBorrowing.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrowing.Location = new Point(-2, 244);
            btnBorrowing.Name = "btnBorrowing";
            btnBorrowing.Size = new Size(154, 52);
            btnBorrowing.TabIndex = 3;
            btnBorrowing.Text = "Borrowing";
            btnBorrowing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrowing.UseVisualStyleBackColor = false;
            btnBorrowing.Click += btnBorrowings_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = SystemColors.Desktop;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnMembers.ForeColor = Color.CornflowerBlue;
            btnMembers.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnMembers.IconColor = Color.LightGray;
            btnMembers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMembers.IconSize = 30;
            btnMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembers.Location = new Point(-2, 192);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(154, 52);
            btnMembers.TabIndex = 2;
            btnMembers.Text = "Members";
            btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = SystemColors.Desktop;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnBooks.ForeColor = Color.CornflowerBlue;
            btnBooks.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnBooks.IconColor = Color.LightGray;
            btnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBooks.IconSize = 30;
            btnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooks.Location = new Point(-2, 140);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(154, 52);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Books       ";
            btnBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = SystemColors.Desktop;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnDashBoard.ForeColor = Color.CornflowerBlue;
            btnDashBoard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            btnDashBoard.IconColor = Color.LightGray;
            btnDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashBoard.IconSize = 30;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 88);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(154, 52);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashboard_Click;
            // 
            // pnlContent
            // 
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(154, 77);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(870, 528);
            pnlContent.TabIndex = 1;
            // 
            // pnlBottom
            // 
            pnlBottom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlBottom.BorderStyle = BorderStyle.FixedSingle;
            pnlBottom.Controls.Add(lblRole);
            pnlBottom.Controls.Add(label2);
            pnlBottom.Controls.Add(lblFullName);
            pnlBottom.Controls.Add(label5);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(154, 539);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(870, 66);
            pnlBottom.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = SystemColors.ControlLightLight;
            lblRole.Location = new Point(808, 1);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(116, 64);
            lblRole.TabIndex = 3;
            lblRole.Text = "UserRole";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(259, 1);
            label2.Name = "label2";
            label2.Size = new Size(138, 64);
            label2.TabIndex = 0;
            label2.Text = "Logged in : ";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = SystemColors.ControlLightLight;
            lblFullName.Location = new Point(397, 1);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(131, 64);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "UserName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(724, 1);
            label5.Name = "label5";
            label5.Size = new Size(84, 64);
            label5.TabIndex = 2;
            label5.Text = "Role : ";
            // 
            // pnlTop
            // 
            pnlTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTop.BackColor = SystemColors.ControlDarkDark;
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(154, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(870, 77);
            pnlTop.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("SimSun", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(352, 18);
            label1.Name = "label1";
            label1.Size = new Size(517, 37);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            CancelButton = btnLogout;
            ClientSize = new Size(1024, 605);
            Controls.Add(pnlBottom);
            Controls.Add(pnlContent);
            Controls.Add(pnlTop);
            Controls.Add(pnlSideBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMain";
            Text = "Library Management System";
            WindowState = FormWindowState.Maximized;
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Panel pnlContent;
        private Panel pnlTop;
        private Panel pnlBottom;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnCategories;
        private FontAwesome.Sharp.IconButton btnBorrowing;
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnBooks;
        private Label label1;
        private Label label2;
        private Label lblRole;
        private Label label5;
        private Label lblFullName;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnAbout;
    }
}
