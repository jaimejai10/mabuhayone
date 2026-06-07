namespace Mabuhayone
{
    partial class dashboardForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            lblOverdueCount = new Label();
            lblOverdue = new Label();
            panel4 = new Panel();
            lblInProgressCount = new Label();
            lblInProgress = new Label();
            panel3 = new Panel();
            lblPendingCount = new Label();
            lblPending = new Label();
            panel2 = new Panel();
            lblTodayTaskCount = new Label();
            lblTodayTask = new Label();
            panel1 = new Panel();
            lblTotalTaskCount = new Label();
            lblTotalTask = new Label();
            panelHeaderDate = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel5, 4, 0);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1068, 90);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.Controls.Add(lblOverdueCount);
            panel5.Controls.Add(lblOverdue);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(852, 0);
            panel5.Margin = new Padding(0, 0, 0, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 80);
            panel5.TabIndex = 4;
            // 
            // lblOverdueCount
            // 
            lblOverdueCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOverdueCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdueCount.ForeColor = Color.White;
            lblOverdueCount.Location = new Point(20, 47);
            lblOverdueCount.Name = "lblOverdueCount";
            lblOverdueCount.Size = new Size(197, 25);
            lblOverdueCount.TabIndex = 1;
            lblOverdueCount.Text = "00";
            lblOverdueCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdue.ForeColor = Color.White;
            lblOverdue.Location = new Point(1, 4);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(126, 25);
            lblOverdue.TabIndex = 0;
            lblOverdue.Text = "Total Tasks";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(98, 102, 244);
            panel4.Controls.Add(lblInProgressCount);
            panel4.Controls.Add(lblInProgress);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(639, 0);
            panel4.Margin = new Padding(0, 0, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 80);
            panel4.TabIndex = 3;
            // 
            // lblInProgressCount
            // 
            lblInProgressCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInProgressCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInProgressCount.ForeColor = Color.White;
            lblInProgressCount.Location = new Point(7, 47);
            lblInProgressCount.Name = "lblInProgressCount";
            lblInProgressCount.Size = new Size(197, 25);
            lblInProgressCount.TabIndex = 1;
            lblInProgressCount.Text = "00";
            lblInProgressCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInProgress.ForeColor = Color.White;
            lblInProgress.Location = new Point(1, 4);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(122, 25);
            lblInProgress.TabIndex = 0;
            lblInProgress.Text = "In Progress";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 74, 130);
            panel3.Controls.Add(lblPendingCount);
            panel3.Controls.Add(lblPending);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(426, 0);
            panel3.Margin = new Padding(0, 0, 10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 80);
            panel3.TabIndex = 2;
            // 
            // lblPendingCount
            // 
            lblPendingCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPendingCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.White;
            lblPendingCount.Location = new Point(7, 47);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(197, 25);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "00";
            lblPendingCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPending.ForeColor = Color.White;
            lblPending.Location = new Point(1, 4);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(91, 25);
            lblPending.TabIndex = 0;
            lblPending.Text = "Pending";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orchid;
            panel2.Controls.Add(lblTodayTaskCount);
            panel2.Controls.Add(lblTodayTask);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(213, 0);
            panel2.Margin = new Padding(0, 0, 10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 80);
            panel2.TabIndex = 1;
            // 
            // lblTodayTaskCount
            // 
            lblTodayTaskCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTodayTaskCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTaskCount.ForeColor = Color.White;
            lblTodayTaskCount.Location = new Point(7, 47);
            lblTodayTaskCount.Name = "lblTodayTaskCount";
            lblTodayTaskCount.Size = new Size(197, 25);
            lblTodayTaskCount.TabIndex = 1;
            lblTodayTaskCount.Text = "00";
            lblTodayTaskCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTodayTask
            // 
            lblTodayTask.AutoSize = true;
            lblTodayTask.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTask.ForeColor = Color.White;
            lblTodayTask.Location = new Point(1, 4);
            lblTodayTask.Name = "lblTodayTask";
            lblTodayTask.Size = new Size(154, 25);
            lblTodayTask.TabIndex = 0;
            lblTodayTask.Text = "Today's Tasks";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(lblTotalTaskCount);
            panel1.Controls.Add(lblTotalTask);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 80);
            panel1.TabIndex = 0;
            // 
            // lblTotalTaskCount
            // 
            lblTotalTaskCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalTaskCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTaskCount.ForeColor = Color.White;
            lblTotalTaskCount.Location = new Point(6, 47);
            lblTotalTaskCount.Name = "lblTotalTaskCount";
            lblTotalTaskCount.Size = new Size(197, 25);
            lblTotalTaskCount.TabIndex = 1;
            lblTotalTaskCount.Text = "00";
            lblTotalTaskCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTask
            // 
            lblTotalTask.AutoSize = true;
            lblTotalTask.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTask.ForeColor = Color.White;
            lblTotalTask.Location = new Point(1, 4);
            lblTotalTask.Name = "lblTotalTask";
            lblTotalTask.Size = new Size(126, 25);
            lblTotalTask.TabIndex = 0;
            lblTotalTask.Text = "Total Tasks";
            // 
            // panelHeaderDate
            // 
            panelHeaderDate.Dock = DockStyle.Top;
            panelHeaderDate.Location = new Point(0, 0);
            panelHeaderDate.Name = "panelHeaderDate";
            panelHeaderDate.Size = new Size(1068, 17);
            panelHeaderDate.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(19, 136);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1032, 149);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 649);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelHeaderDate);
            Name = "dashboardForm";
            Text = "dashboardForm";
            Load += dashboardForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Label lblOverdueCount;
        private Label lblOverdue;
        private Panel panel4;
        private Label lblInProgressCount;
        private Label lblInProgress;
        private Panel panel3;
        private Label lblPendingCount;
        private Label lblPending;
        private Panel panel2;
        private Label lblTodayTaskCount;
        private Label lblTodayTask;
        private Panel panel1;
        private Label lblTotalTaskCount;
        private Label lblTotalTask;
        private Panel panelHeaderDate;
        private TableLayoutPanel tableLayoutPanel2;
    }
}