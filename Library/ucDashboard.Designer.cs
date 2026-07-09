using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Library.UI
{
    partial class ucDashboard
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
            panel1 = new Panel();
            lblDate = new Label();
            lblWelcome = new Label();
            panel2 = new Panel();
            lblMembers = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblTotalBooks = new Label();
            label1 = new Label();
            panel4 = new Panel();
            lblBorrowed = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lblOverdue = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 135);
            panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold);
            lblDate.ForeColor = SystemColors.ControlLightLight;
            lblDate.Location = new Point(697, 61);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(74, 64);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold);
            lblWelcome.ForeColor = SystemColors.ControlLightLight;
            lblWelcome.Location = new Point(181, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(117, 64);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(lblMembers);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(563, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 210);
            panel2.TabIndex = 1;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembers.Location = new Point(232, 81);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(41, 48);
            lblMembers.TabIndex = 4;
            lblMembers.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 22);
            label3.Name = "label3";
            label3.Size = new Size(177, 48);
            label3.TabIndex = 3;
            label3.Text = "Members";
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(lblTotalBooks);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(47, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(510, 210);
            panel3.TabIndex = 2;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooks.Location = new Point(252, 81);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(41, 48);
            lblTotalBooks.TabIndex = 2;
            lblTotalBooks.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 22);
            label1.Name = "label1";
            label1.Size = new Size(224, 48);
            label1.TabIndex = 1;
            label1.Text = "Total Books";
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(lblBorrowed);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(47, 357);
            panel4.Name = "panel4";
            panel4.Size = new Size(510, 210);
            panel4.TabIndex = 4;
            // 
            // lblBorrowed
            // 
            lblBorrowed.AutoSize = true;
            lblBorrowed.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowed.Location = new Point(252, 85);
            lblBorrowed.Name = "lblBorrowed";
            lblBorrowed.Size = new Size(41, 48);
            lblBorrowed.TabIndex = 6;
            lblBorrowed.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(181, 26);
            label4.Name = "label4";
            label4.Size = new Size(182, 48);
            label4.TabIndex = 5;
            label4.Text = "Borrowed";
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(lblOverdue);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(563, 357);
            panel5.Name = "panel5";
            panel5.Size = new Size(510, 210);
            panel5.TabIndex = 3;
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdue.Location = new Point(232, 85);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(41, 48);
            lblOverdue.TabIndex = 8;
            lblOverdue.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(170, 26);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(165, 48);
            label5.TabIndex = 7;
            label5.Text = "Overdue";
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucDashboard";
            Size = new Size(1076, 570);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblDate;
        private Label lblWelcome;
        private Label label1;
        private Label lblMembers;
        private Label label3;
        private Label lblTotalBooks;
        private Label lblBorrowed;
        private Label label4;
        private Label lblOverdue;
        private Label label5;
    }
}