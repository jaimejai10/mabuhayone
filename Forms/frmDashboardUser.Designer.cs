namespace Mabuhayone.Forms
{
    partial class frmDashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardUser));
            panelContainer = new Panel();
            tableLayoutPanelAnalyticsRow = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanelSummaryCards = new TableLayoutPanel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lblPendingCount = new Label();
            lblPending = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            lblCompleted = new Label();
            lblComplted = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            lblOverdueCount = new Label();
            lblOverdue = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblTotalTaskCount = new Label();
            lblTotalTask = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTodayTask = new Label();
            lblTodayTaskCount = new Label();
            panelContainer.SuspendLayout();
            tableLayoutPanelAnalyticsRow.SuspendLayout();
            tableLayoutPanelSummaryCards.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = SystemColors.ControlLight;
            panelContainer.Controls.Add(tableLayoutPanelAnalyticsRow);
            panelContainer.Controls.Add(tableLayoutPanelSummaryCards);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(10);
            panelContainer.Size = new Size(1173, 527);
            panelContainer.TabIndex = 8;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // tableLayoutPanelAnalyticsRow
            // 
            tableLayoutPanelAnalyticsRow.AutoSize = true;
            tableLayoutPanelAnalyticsRow.ColumnCount = 2;
            tableLayoutPanelAnalyticsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAnalyticsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanelAnalyticsRow.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanelAnalyticsRow.Dock = DockStyle.Top;
            tableLayoutPanelAnalyticsRow.Location = new Point(10, 100);
            tableLayoutPanelAnalyticsRow.Name = "tableLayoutPanelAnalyticsRow";
            tableLayoutPanelAnalyticsRow.RowCount = 1;
            tableLayoutPanelAnalyticsRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAnalyticsRow.Size = new Size(1153, 0);
            tableLayoutPanelAnalyticsRow.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(803, 1);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelSummaryCards
            // 
            tableLayoutPanelSummaryCards.ColumnCount = 5;
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.Controls.Add(panel3, 3, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel4, 2, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel5, 4, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel2, 1, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel1, 0, 0);
            tableLayoutPanelSummaryCards.Dock = DockStyle.Top;
            tableLayoutPanelSummaryCards.Location = new Point(10, 10);
            tableLayoutPanelSummaryCards.Name = "tableLayoutPanelSummaryCards";
            tableLayoutPanelSummaryCards.RowCount = 1;
            tableLayoutPanelSummaryCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSummaryCards.Size = new Size(1153, 90);
            tableLayoutPanelSummaryCards.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 74, 130);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblPendingCount);
            panel3.Controls.Add(lblPending);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(690, 0);
            panel3.Margin = new Padding(0, 0, 10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 80);
            panel3.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblPendingCount
            // 
            lblPendingCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPendingCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.White;
            lblPendingCount.Location = new Point(82, 47);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(134, 25);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "00";
            lblPendingCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPending.ForeColor = Color.White;
            lblPending.Location = new Point(72, 4);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(106, 20);
            lblPending.TabIndex = 0;
            lblPending.Text = "Total Pending";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(98, 102, 244);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblCompleted);
            panel4.Controls.Add(lblComplted);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(460, 0);
            panel4.Margin = new Padding(0, 0, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 80);
            panel4.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblCompleted
            // 
            lblCompleted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCompleted.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompleted.ForeColor = Color.White;
            lblCompleted.Location = new Point(82, 47);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(134, 25);
            lblCompleted.TabIndex = 1;
            lblCompleted.Text = "00";
            lblCompleted.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblComplted
            // 
            lblComplted.AutoSize = true;
            lblComplted.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplted.ForeColor = Color.White;
            lblComplted.Location = new Point(74, 4);
            lblComplted.Name = "lblComplted";
            lblComplted.Size = new Size(116, 20);
            lblComplted.TabIndex = 0;
            lblComplted.Text = "Total Complete";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(lblOverdueCount);
            panel5.Controls.Add(lblOverdue);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(920, 0);
            panel5.Margin = new Padding(0, 0, 0, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 80);
            panel5.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(6, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // lblOverdueCount
            // 
            lblOverdueCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOverdueCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdueCount.ForeColor = Color.White;
            lblOverdueCount.Location = new Point(80, 47);
            lblOverdueCount.Name = "lblOverdueCount";
            lblOverdueCount.Size = new Size(146, 25);
            lblOverdueCount.TabIndex = 1;
            lblOverdueCount.Text = "00";
            lblOverdueCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOverdue.ForeColor = Color.White;
            lblOverdue.Location = new Point(73, 4);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(108, 20);
            lblOverdue.TabIndex = 0;
            lblOverdue.Text = "Total Overdue";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orchid;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTotalTaskCount);
            panel2.Controls.Add(lblTotalTask);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(230, 0);
            panel2.Margin = new Padding(0, 0, 10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 80);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblTotalTaskCount
            // 
            lblTotalTaskCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalTaskCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTaskCount.ForeColor = Color.White;
            lblTotalTaskCount.Location = new Point(79, 47);
            lblTotalTaskCount.Name = "lblTotalTaskCount";
            lblTotalTaskCount.Size = new Size(135, 25);
            lblTotalTaskCount.TabIndex = 1;
            lblTotalTaskCount.Text = "00";
            lblTotalTaskCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTask
            // 
            lblTotalTask.AutoSize = true;
            lblTotalTask.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTask.ForeColor = Color.White;
            lblTotalTask.Location = new Point(72, 4);
            lblTotalTask.Name = "lblTotalTask";
            lblTotalTask.Size = new Size(90, 20);
            lblTotalTask.TabIndex = 0;
            lblTotalTask.Text = "Total Tasks";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTodayTask);
            panel1.Controls.Add(lblTodayTaskCount);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 80);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTodayTask
            // 
            lblTodayTask.AutoSize = true;
            lblTodayTask.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayTask.ForeColor = Color.White;
            lblTodayTask.Location = new Point(70, 3);
            lblTodayTask.Name = "lblTodayTask";
            lblTodayTask.Size = new Size(109, 20);
            lblTodayTask.TabIndex = 0;
            lblTodayTask.Text = "Today's Tasks";
            // 
            // lblTodayTaskCount
            // 
            lblTodayTaskCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTodayTaskCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTaskCount.ForeColor = Color.White;
            lblTodayTaskCount.Location = new Point(77, 47);
            lblTodayTaskCount.Name = "lblTodayTaskCount";
            lblTodayTaskCount.Size = new Size(138, 25);
            lblTodayTaskCount.TabIndex = 1;
            lblTodayTaskCount.Text = "00";
            lblTodayTaskCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmDashboardUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 527);
            Controls.Add(panelContainer);
            Name = "frmDashboardUser";
            Text = "Dashboard";
            Load += frmDashboardUser_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            tableLayoutPanelAnalyticsRow.ResumeLayout(false);
            tableLayoutPanelAnalyticsRow.PerformLayout();
            tableLayoutPanelSummaryCards.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private TableLayoutPanel tableLayoutPanelAnalyticsRow;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelSummaryCards;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label lblOverdueCount;
        private Label lblOverdue;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lblTotalTaskCount;
        private Label lblTotalTask;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTodayTask;
        private Label lblTodayTaskCount;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label lblCompleted;
        private Label lblComplted;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label lblPendingCount;
        private Label lblPending;
    }
}