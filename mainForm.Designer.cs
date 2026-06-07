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
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnProfile = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            btnTask = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
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
            panel7 = new Panel();
            lblInprogress = new Label();
            iconButton14 = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            lblDeadline = new Label();
            iconButton13 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            iconButton12 = new FontAwesome.Sharp.IconButton();
            lblComplete = new Label();
            panel4 = new Panel();
            lblOverdue = new Label();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            lblTask = new Label();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            panelNotification = new Panel();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            lblNotification = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDesktop.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelNotification.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(98, 102, 244);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Controls.Add(iconButton6);
            panelMenu.Controls.Add(btnTask);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 761);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
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
            btnLogout.Size = new Size(220, 36);
            btnLogout.TabIndex = 7;
            btnLogout.Tag = "Logout";
            btnLogout.Text = "  Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Verdana", 10F);
            btnProfile.ForeColor = Color.White;
            btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnProfile.IconColor = Color.White;
            btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfile.IconSize = 30;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 341);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(10, 0, 20, 0);
            btnProfile.Size = new Size(220, 50);
            btnProfile.TabIndex = 6;
            btnProfile.Tag = "Profile";
            btnProfile.Text = "Profile";
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // iconButton6
            // 
            iconButton6.Dock = DockStyle.Top;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Verdana", 10F);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 291);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(10, 0, 20, 0);
            iconButton6.Size = new Size(220, 50);
            iconButton6.TabIndex = 5;
            iconButton6.Tag = "Settings";
            iconButton6.Text = "Settings";
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // btnTask
            // 
            btnTask.Dock = DockStyle.Top;
            btnTask.FlatAppearance.BorderSize = 0;
            btnTask.FlatStyle = FlatStyle.Flat;
            btnTask.Font = new Font("Verdana", 10F);
            btnTask.ForeColor = Color.White;
            btnTask.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnTask.IconColor = Color.White;
            btnTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTask.IconSize = 30;
            btnTask.ImageAlign = ContentAlignment.MiddleLeft;
            btnTask.Location = new Point(0, 241);
            btnTask.Name = "btnTask";
            btnTask.Padding = new Padding(10, 0, 20, 0);
            btnTask.Size = new Size(220, 50);
            btnTask.TabIndex = 4;
            btnTask.Tag = "All Tasks";
            btnTask.Text = "All Tasks";
            btnTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Verdana", 10F);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Male;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 191);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 20, 0);
            iconButton4.Size = new Size(220, 50);
            iconButton4.TabIndex = 3;
            iconButton4.Tag = "Manage Users";
            iconButton4.Text = "Manage Users";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Verdana", 10F);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Building;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 141);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(220, 50);
            iconButton3.TabIndex = 2;
            iconButton3.Tag = "Manage Companies";
            iconButton3.Text = "Manage Companies";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Verdana", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 30;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 91);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 20, 0);
            btnDashboard.Size = new Size(220, 50);
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
            panel1.Size = new Size(220, 91);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 30;
            btnMenu.Location = new Point(167, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(60, 60);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 66);
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
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1044, 60);
            panelTitleBar.TabIndex = 1;
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
            lblFullname.Location = new Point(894, 22);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(49, 17);
            lblFullname.TabIndex = 6;
            lblFullname.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(866, 25);
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
            lblPosition.Location = new Point(894, 37);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(38, 13);
            lblPosition.TabIndex = 9;
            lblPosition.Text = "label1";
            // 
            // iconButton8
            // 
            iconButton8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton8.Cursor = Cursors.Hand;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconButton8.IconColor = SystemColors.WindowFrame;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 30;
            iconButton8.Location = new Point(833, 24);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(28, 28);
            iconButton8.TabIndex = 10;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            iconButton1.IconColor = SystemColors.WindowFrame;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(1013, 29);
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
            btnMinimize.Location = new Point(966, -1);
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
            btnMaximize.Location = new Point(991, -1);
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
            btnClose.Location = new Point(1017, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(245, 245, 255);
            panelDesktop.Controls.Add(panel7);
            panelDesktop.Controls.Add(panel6);
            panelDesktop.Controls.Add(panel5);
            panelDesktop.Controls.Add(panel4);
            panelDesktop.Controls.Add(panel3);
            panelDesktop.Controls.Add(panelNotification);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1044, 701);
            panelDesktop.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LimeGreen;
            panel7.Controls.Add(lblInprogress);
            panel7.Controls.Add(iconButton14);
            panel7.Location = new Point(84, 422);
            panel7.Name = "panel7";
            panel7.Size = new Size(229, 144);
            panel7.TabIndex = 5;
            // 
            // lblInprogress
            // 
            lblInprogress.AutoSize = true;
            lblInprogress.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInprogress.ForeColor = Color.White;
            lblInprogress.Location = new Point(32, 110);
            lblInprogress.Name = "lblInprogress";
            lblInprogress.Size = new Size(169, 23);
            lblInprogress.TabIndex = 3;
            lblInprogress.Text = "25 In Progress";
            lblInprogress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton14
            // 
            iconButton14.FlatAppearance.BorderSize = 0;
            iconButton14.FlatStyle = FlatStyle.Flat;
            iconButton14.IconChar = FontAwesome.Sharp.IconChar.Tools;
            iconButton14.IconColor = Color.White;
            iconButton14.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton14.IconSize = 100;
            iconButton14.Location = new Point(72, 11);
            iconButton14.Name = "iconButton14";
            iconButton14.Size = new Size(85, 96);
            iconButton14.TabIndex = 2;
            iconButton14.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Controls.Add(lblDeadline);
            panel6.Controls.Add(iconButton13);
            panel6.Location = new Point(361, 422);
            panel6.Name = "panel6";
            panel6.Size = new Size(229, 144);
            panel6.TabIndex = 4;
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeadline.ForeColor = Color.White;
            lblDeadline.Location = new Point(25, 111);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(184, 23);
            lblDeadline.TabIndex = 3;
            lblDeadline.Text = "13 No. Deadline";
            lblDeadline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton13
            // 
            iconButton13.FlatAppearance.BorderSize = 0;
            iconButton13.FlatStyle = FlatStyle.Flat;
            iconButton13.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconButton13.IconColor = Color.White;
            iconButton13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton13.IconSize = 100;
            iconButton13.Location = new Point(72, 11);
            iconButton13.Name = "iconButton13";
            iconButton13.Size = new Size(85, 96);
            iconButton13.TabIndex = 2;
            iconButton13.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(98, 102, 244);
            panel5.Controls.Add(iconButton12);
            panel5.Controls.Add(lblComplete);
            panel5.Location = new Point(639, 422);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 144);
            panel5.TabIndex = 3;
            // 
            // iconButton12
            // 
            iconButton12.FlatAppearance.BorderSize = 0;
            iconButton12.FlatStyle = FlatStyle.Flat;
            iconButton12.IconChar = FontAwesome.Sharp.IconChar.CheckToSlot;
            iconButton12.IconColor = Color.White;
            iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton12.IconSize = 100;
            iconButton12.Location = new Point(69, 12);
            iconButton12.Name = "iconButton12";
            iconButton12.Size = new Size(85, 96);
            iconButton12.TabIndex = 1;
            iconButton12.UseVisualStyleBackColor = true;
            // 
            // lblComplete
            // 
            lblComplete.AutoSize = true;
            lblComplete.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplete.ForeColor = Color.White;
            lblComplete.Location = new Point(45, 111);
            lblComplete.Name = "lblComplete";
            lblComplete.Size = new Size(147, 23);
            lblComplete.TabIndex = 0;
            lblComplete.Text = "25 Complete";
            lblComplete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 74, 130);
            panel4.Controls.Add(lblOverdue);
            panel4.Controls.Add(iconButton11);
            panel4.Location = new Point(639, 242);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 144);
            panel4.TabIndex = 2;
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdue.ForeColor = Color.White;
            lblOverdue.Location = new Point(48, 112);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(135, 23);
            lblOverdue.TabIndex = 4;
            lblOverdue.Text = "25 Overdue";
            lblOverdue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton11
            // 
            iconButton11.FlatAppearance.BorderSize = 0;
            iconButton11.FlatStyle = FlatStyle.Flat;
            iconButton11.IconChar = FontAwesome.Sharp.IconChar.Warning;
            iconButton11.IconColor = Color.White;
            iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton11.IconSize = 100;
            iconButton11.Location = new Point(72, 6);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(85, 96);
            iconButton11.TabIndex = 3;
            iconButton11.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orchid;
            panel3.Controls.Add(lblTask);
            panel3.Controls.Add(iconButton10);
            panel3.Location = new Point(361, 242);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 144);
            panel3.TabIndex = 1;
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTask.ForeColor = Color.White;
            lblTask.Location = new Point(45, 112);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(142, 23);
            lblTask.TabIndex = 3;
            lblTask.Text = "25 All Tasks";
            lblTask.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconButton10
            // 
            iconButton10.FlatAppearance.BorderSize = 0;
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.TableList;
            iconButton10.IconColor = Color.White;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 100;
            iconButton10.Location = new Point(72, 11);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(85, 96);
            iconButton10.TabIndex = 2;
            iconButton10.UseVisualStyleBackColor = true;
            // 
            // panelNotification
            // 
            panelNotification.BackColor = Color.DarkTurquoise;
            panelNotification.Controls.Add(iconButton9);
            panelNotification.Controls.Add(lblNotification);
            panelNotification.Location = new Point(84, 243);
            panelNotification.Name = "panelNotification";
            panelNotification.Size = new Size(229, 144);
            panelNotification.TabIndex = 0;
            // 
            // iconButton9
            // 
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconButton9.IconColor = Color.White;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.IconSize = 100;
            iconButton9.Location = new Point(69, 12);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(85, 96);
            iconButton9.TabIndex = 1;
            iconButton9.UseVisualStyleBackColor = true;
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotification.ForeColor = Color.White;
            lblNotification.Location = new Point(18, 109);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(183, 23);
            lblNotification.TabIndex = 0;
            lblNotification.Text = "25 Notifications";
            lblNotification.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 761);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "mainForm";
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
            panelDesktop.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelNotification.ResumeLayout(false);
            panelNotification.PerformLayout();
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
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnTask;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Panel panel4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton10;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton12;
        private Label lblComplete;
        private Label lblOverdue;
        private FontAwesome.Sharp.IconButton iconButton11;
        private Label lblTask;
        private Panel panel7;
        private Label lblInprogress;
        private FontAwesome.Sharp.IconButton iconButton14;
        private Panel panel6;
        private Label lblDeadline;
        private Panel panelNotification;
        private FontAwesome.Sharp.IconButton iconButton9;
        private Label lblNotification;
        private FontAwesome.Sharp.IconButton iconButton13;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox2;
        private Label lblFullname;
        private Label lblPosition;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    }
}
