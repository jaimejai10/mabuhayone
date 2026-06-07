namespace Mabuhayone
{
    partial class loginForm
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
            panel1 = new Panel();
            lblError = new Label();
            btnClose = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            btnLogin = new Button();
            label5 = new Label();
            panel4 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel5 = new Panel();
            txtPassword = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            txtUsername = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 652);
            panel1.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(52, 404);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 15;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.Black;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(400, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 31);
            btnClose.TabIndex = 14;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(91, 618);
            label6.Name = "label6";
            label6.Size = new Size(245, 21);
            label6.TabIndex = 13;
            label6.Text = "Developer by: MOC MIS TEAM";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(141, 502);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(136, 17);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot My Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(98, 102, 244);
            btnLogin.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(45, 448);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(329, 36);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 104);
            label5.Name = "label5";
            label5.Size = new Size(299, 21);
            label5.TabIndex = 9;
            label5.Text = "Easy and Fast Task Monitoring System";
            // 
            // panel4
            // 
            panel4.Controls.Add(iconPictureBox2);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtPassword);
            panel4.Location = new Point(45, 362);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 36);
            panel4.TabIndex = 8;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.FromArgb(98, 102, 244);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.FromArgb(98, 102, 244);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 26;
            iconPictureBox2.Location = new Point(301, 7);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(28, 26);
            iconPictureBox2.TabIndex = 4;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.Click += iconPictureBox2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(98, 102, 244);
            panel5.Location = new Point(1, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(328, 1);
            panel5.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(3, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(292, 16);
            txtPassword.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 339);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(45, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 36);
            panel2.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(5, 10);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(286, 16);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(98, 102, 244);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.FromArgb(98, 102, 244);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 26;
            iconPictureBox1.Location = new Point(297, 6);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(28, 26);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(98, 102, 244);
            panel3.Location = new Point(1, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 1);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 248);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 204);
            label2.Name = "label2";
            label2.Size = new Size(179, 24);
            label2.TabIndex = 2;
            label2.Text = "Welcome Back !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 71);
            label1.Name = "label1";
            label1.Size = new Size(360, 33);
            label1.TabIndex = 1;
            label1.Text = "Mabuhayone Corporation";
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderColor = Color.White;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Black;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 20;
            btnMinimize.Location = new Point(363, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(31, 31);
            btnMinimize.TabIndex = 16;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 240, 241);
            ClientSize = new Size(432, 650);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Button btnLogin;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label6;
        private LinkLabel linkLabel2;
        private FontAwesome.Sharp.IconButton btnClose;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblError;
        private FontAwesome.Sharp.IconButton btnMinimize;
    }
}