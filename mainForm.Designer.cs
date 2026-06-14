namespace Mabuhayone
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            panelMenu = new Panel();
            btnApplyLeave = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnProfile = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnTask = new FontAwesome.Sharp.IconButton();
            btnManageUsers = new FontAwesome.Sharp.IconButton();
            btnManageCompanies = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            lblFullname = new Label();
            pictureBox2 = new PictureBox();
            lblPosition = new Label();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(98, 102, 244);
            panelMenu.Controls.Add(btnApplyLeave);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnTask);
            panelMenu.Controls.Add(btnManageUsers);
            panelMenu.Controls.Add(btnManageCompanies);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 761);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnApplyLeave
            // 
            btnApplyLeave.Cursor = Cursors.Hand;
            btnApplyLeave.Dock = DockStyle.Top;
            btnApplyLeave.FlatAppearance.BorderSize = 0;
            btnApplyLeave.FlatStyle = FlatStyle.Flat;
            btnApplyLeave.Font = new Font("Verdana", 9F);
            btnApplyLeave.ForeColor = Color.White;
            btnApplyLeave.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            btnApplyLeave.IconColor = Color.White;
            btnApplyLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnApplyLeave.IconSize = 25;
            btnApplyLeave.ImageAlign = ContentAlignment.MiddleLeft;
            btnApplyLeave.Location = new Point(0, 391);
            btnApplyLeave.Name = "btnApplyLeave";
            btnApplyLeave.Padding = new Padding(10, 0, 10, 0);
            btnApplyLeave.Size = new Size(190, 50);
            btnApplyLeave.TabIndex = 8;
            btnApplyLeave.Tag = "Apply Leave";
            btnApplyLeave.Text = "Apply Leave";
            btnApplyLeave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplyLeave.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana", 10F);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 30;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 725);
            btnLogout.Margin = new Padding(3, 3, 3, 30);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(190, 36);
            btnLogout.TabIndex = 7;
            btnLogout.Tag = "Logout";
            btnLogout.Text = "  Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Verdana", 9F);
            btnProfile.ForeColor = Color.White;
            btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnProfile.IconColor = Color.White;
            btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfile.IconSize = 25;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 341);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(10, 0, 10, 0);
            btnProfile.Size = new Size(190, 50);
            btnProfile.TabIndex = 6;
            btnProfile.Tag = "Profile";
            btnProfile.Text = "Profile";
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Verdana", 9F);
            btnSettings.ForeColor = Color.White;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            btnSettings.IconColor = Color.White;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 25;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 291);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 10, 0);
            btnSettings.Size = new Size(190, 50);
            btnSettings.TabIndex = 5;
            btnSettings.Tag = "Settings";
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnTask
            // 
            btnTask.Cursor = Cursors.Hand;
            btnTask.Dock = DockStyle.Top;
            btnTask.FlatAppearance.BorderSize = 0;
            btnTask.FlatStyle = FlatStyle.Flat;
            btnTask.Font = new Font("Verdana", 9F);
            btnTask.ForeColor = Color.White;
            btnTask.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnTask.IconColor = Color.White;
            btnTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTask.IconSize = 25;
            btnTask.ImageAlign = ContentAlignment.MiddleLeft;
            btnTask.Location = new Point(0, 241);
            btnTask.Name = "btnTask";
            btnTask.Padding = new Padding(10, 0, 10, 0);
            btnTask.Size = new Size(190, 50);
            btnTask.TabIndex = 4;
            btnTask.Tag = "All Tasks";
            btnTask.Text = "All Tasks";
            btnTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Cursor = Cursors.Hand;
            btnManageUsers.Dock = DockStyle.Top;
            btnManageUsers.FlatAppearance.BorderSize = 0;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.Font = new Font("Verdana", 9F);
            btnManageUsers.ForeColor = Color.White;
            btnManageUsers.IconChar = FontAwesome.Sharp.IconChar.Male;
            btnManageUsers.IconColor = Color.White;
            btnManageUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnManageUsers.IconSize = 25;
            btnManageUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageUsers.Location = new Point(0, 191);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Padding = new Padding(10, 0, 10, 0);
            btnManageUsers.Size = new Size(190, 50);
            btnManageUsers.TabIndex = 3;
            btnManageUsers.Tag = "Manage Users";
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageCompanies
            // 
            btnManageCompanies.Cursor = Cursors.Hand;
            btnManageCompanies.Dock = DockStyle.Top;
            btnManageCompanies.FlatAppearance.BorderSize = 0;
            btnManageCompanies.FlatStyle = FlatStyle.Flat;
            btnManageCompanies.Font = new Font("Verdana", 9F);
            btnManageCompanies.ForeColor = Color.White;
            btnManageCompanies.IconChar = FontAwesome.Sharp.IconChar.Building;
            btnManageCompanies.IconColor = Color.White;
            btnManageCompanies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnManageCompanies.IconSize = 25;
            btnManageCompanies.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageCompanies.Location = new Point(0, 141);
            btnManageCompanies.Name = "btnManageCompanies";
            btnManageCompanies.Padding = new Padding(10, 0, 10, 0);
            btnManageCompanies.Size = new Size(190, 50);
            btnManageCompanies.TabIndex = 2;
            btnManageCompanies.Tag = "Manage Companies";
            btnManageCompanies.Text = "Manage Companies";
            btnManageCompanies.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageCompanies.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Verdana", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 25;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 91);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 10, 0);
            btnDashboard.Size = new Size(190, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Tag = "Dashboard";
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 91);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 25;
            btnMenu.Location = new Point(145, 14);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 40);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "test";
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Controls.Add(lblFullname);
            panelTitleBar.Controls.Add(pictureBox2);
            panelTitleBar.Controls.Add(lblPosition);
            panelTitleBar.Controls.Add(iconButton8);
            panelTitleBar.Controls.Add(iconButton1);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(190, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1251, 60);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.White;
            iconCurrentChildForm.ForeColor = SystemColors.WindowFrame;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = SystemColors.WindowFrame;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 35;
            iconCurrentChildForm.Location = new Point(17, 13);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(35, 37);
            iconCurrentChildForm.TabIndex = 11;
            iconCurrentChildForm.TabStop = false;
            // 
            // lblFullname
            // 
            lblFullname.Anchor = AnchorStyles.Right;
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = SystemColors.WindowFrame;
            lblFullname.Location = new Point(1068, 27);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(49, 17);
            lblFullname.TabIndex = 6;
            lblFullname.Text = "label1";
            lblFullname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1040, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "";
            // 
            // lblPosition
            // 
            lblPosition.Anchor = AnchorStyles.Right;
            lblPosition.AutoSize = true;
            lblPosition.BackColor = Color.Transparent;
            lblPosition.FlatStyle = FlatStyle.Flat;
            lblPosition.Font = new Font("Segoe UI Historic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = SystemColors.WindowFrame;
            lblPosition.Location = new Point(1068, 42);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(38, 13);
            lblPosition.TabIndex = 9;
            lblPosition.Text = "label1";
            lblPosition.TextAlign = ContentAlignment.MiddleRight;
            // 
            // iconButton8
            // 
            iconButton8.Anchor = AnchorStyles.Right;
            iconButton8.Cursor = Cursors.Hand;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconButton8.IconColor = SystemColors.WindowFrame;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 30;
            iconButton8.Location = new Point(1007, 29);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(28, 28);
            iconButton8.TabIndex = 10;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Right;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            iconButton1.IconColor = SystemColors.WindowFrame;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(1220, 29);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(28, 28);
            iconButton1.TabIndex = 8;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = SystemColors.WindowFrame;
            lblTitleChildForm.Location = new Point(50, 15);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(80, 25);
            lblTitleChildForm.TabIndex = 7;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.Click += lblTitleChildForm_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.White;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = SystemColors.WindowFrame;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 15;
            btnMinimize.Location = new Point(1173, -1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 4;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.White;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = SystemColors.WindowFrame;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 15;
            btnMaximize.Location = new Point(1198, -1);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(25, 25);
            btnMaximize.TabIndex = 3;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = SystemColors.WindowFrame;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 15;
            btnClose.Location = new Point(1224, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(245, 245, 255);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(190, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1251, 701);
            panelDesktop.TabIndex = 2;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1441, 761);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += mainForm_Load_1;
            Resize += Form1_Resize;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnMenu;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnTask;
        private FontAwesome.Sharp.IconButton btnManageUsers;
        private FontAwesome.Sharp.IconButton btnManageCompanies;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox2;
        private Label lblFullname;
        private Label lblPosition;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnApplyLeave;
    }
}
