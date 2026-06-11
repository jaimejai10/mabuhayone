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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelHeaderDate = new Panel();
            panelContainer = new Panel();
            panelDataGrid = new Panel();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panelRecentActivity = new Panel();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanelAnalyticsRow = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanelSummaryCards = new TableLayoutPanel();
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
            panelContainer.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            tableLayoutPanelAnalyticsRow.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            tableLayoutPanelSummaryCards.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeaderDate
            // 
            panelHeaderDate.Dock = DockStyle.Top;
            panelHeaderDate.Location = new Point(0, 0);
            panelHeaderDate.Name = "panelHeaderDate";
            panelHeaderDate.Size = new Size(1184, 17);
            panelHeaderDate.TabIndex = 2;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = SystemColors.ControlLight;
            panelContainer.Controls.Add(panelDataGrid);
            panelContainer.Controls.Add(panelRecentActivity);
            panelContainer.Controls.Add(tableLayoutPanelAnalyticsRow);
            panelContainer.Controls.Add(tableLayoutPanelSummaryCards);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 17);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(10);
            panelContainer.Size = new Size(1184, 744);
            panelContainer.TabIndex = 7;
            // 
            // panelDataGrid
            // 
            panelDataGrid.BackColor = Color.White;
            panelDataGrid.Controls.Add(label2);
            panelDataGrid.Controls.Add(label1);
            panelDataGrid.Controls.Add(dataGridView1);
            panelDataGrid.Dock = DockStyle.Top;
            panelDataGrid.Location = new Point(10, 360);
            panelDataGrid.Margin = new Padding(0);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(964, 374);
            panelDataGrid.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(952, 333);
            dataGridView1.TabIndex = 0;
            // 
            // panelRecentActivity
            // 
            panelRecentActivity.Controls.Add(chart4);
            panelRecentActivity.Dock = DockStyle.Right;
            panelRecentActivity.Location = new Point(974, 360);
            panelRecentActivity.Name = "panelRecentActivity";
            panelRecentActivity.Padding = new Padding(10, 0, 0, 0);
            panelRecentActivity.Size = new Size(200, 374);
            panelRecentActivity.TabIndex = 9;
            // 
            // chart4
            // 
            chartArea1.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea1);
            chart4.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart4.Legends.Add(legend1);
            chart4.Location = new Point(10, 0);
            chart4.Name = "chart4";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart4.Series.Add(series1);
            chart4.Size = new Size(190, 374);
            chart4.TabIndex = 0;
            chart4.Text = "chart4";
            // 
            // tableLayoutPanelAnalyticsRow
            // 
            tableLayoutPanelAnalyticsRow.AutoSize = true;
            tableLayoutPanelAnalyticsRow.ColumnCount = 2;
            tableLayoutPanelAnalyticsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAnalyticsRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanelAnalyticsRow.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanelAnalyticsRow.Controls.Add(chart3, 1, 0);
            tableLayoutPanelAnalyticsRow.Dock = DockStyle.Top;
            tableLayoutPanelAnalyticsRow.Location = new Point(10, 100);
            tableLayoutPanelAnalyticsRow.Name = "tableLayoutPanelAnalyticsRow";
            tableLayoutPanelAnalyticsRow.RowCount = 1;
            tableLayoutPanelAnalyticsRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAnalyticsRow.Size = new Size(1164, 260);
            tableLayoutPanelAnalyticsRow.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(chart1);
            flowLayoutPanel1.Controls.Add(chart2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(814, 260);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(0, 0);
            chart1.Margin = new Padding(0, 0, 10, 10);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(300, 250);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart2.Legends.Add(legend3);
            chart2.Location = new Point(310, 0);
            chart2.Margin = new Padding(0, 0, 10, 10);
            chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart2.Series.Add(series3);
            chart2.Size = new Size(300, 250);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea4);
            chart3.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            chart3.Legends.Add(legend4);
            chart3.Location = new Point(814, 0);
            chart3.Margin = new Padding(0, 0, 0, 10);
            chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart3.Series.Add(series4);
            chart3.Size = new Size(350, 250);
            chart3.TabIndex = 1;
            chart3.Text = "chart3";
            // 
            // tableLayoutPanelSummaryCards
            // 
            tableLayoutPanelSummaryCards.ColumnCount = 5;
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummaryCards.Controls.Add(panel5, 4, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel4, 3, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel3, 2, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel2, 1, 0);
            tableLayoutPanelSummaryCards.Controls.Add(panel1, 0, 0);
            tableLayoutPanelSummaryCards.Dock = DockStyle.Top;
            tableLayoutPanelSummaryCards.Location = new Point(10, 10);
            tableLayoutPanelSummaryCards.Name = "tableLayoutPanelSummaryCards";
            tableLayoutPanelSummaryCards.RowCount = 1;
            tableLayoutPanelSummaryCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSummaryCards.Size = new Size(1164, 90);
            tableLayoutPanelSummaryCards.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.Controls.Add(lblOverdueCount);
            panel5.Controls.Add(lblOverdue);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(928, 0);
            panel5.Margin = new Padding(0, 0, 0, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 80);
            panel5.TabIndex = 4;
            // 
            // lblOverdueCount
            // 
            lblOverdueCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOverdueCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdueCount.ForeColor = Color.White;
            lblOverdueCount.Location = new Point(16, 47);
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
            panel4.Location = new Point(696, 0);
            panel4.Margin = new Padding(0, 0, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 80);
            panel4.TabIndex = 3;
            // 
            // lblInProgressCount
            // 
            lblInProgressCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInProgressCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInProgressCount.ForeColor = Color.White;
            lblInProgressCount.Location = new Point(1, 47);
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
            panel3.Location = new Point(464, 0);
            panel3.Margin = new Padding(0, 0, 10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 80);
            panel3.TabIndex = 2;
            // 
            // lblPendingCount
            // 
            lblPendingCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPendingCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.White;
            lblPendingCount.Location = new Point(12, 47);
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
            panel2.Location = new Point(232, 0);
            panel2.Margin = new Padding(0, 0, 10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 80);
            panel2.TabIndex = 1;
            // 
            // lblTodayTaskCount
            // 
            lblTodayTaskCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTodayTaskCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTaskCount.ForeColor = Color.White;
            lblTodayTaskCount.Location = new Point(10, 47);
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
            panel1.Size = new Size(222, 80);
            panel1.TabIndex = 0;
            // 
            // lblTotalTaskCount
            // 
            lblTotalTaskCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalTaskCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTaskCount.ForeColor = Color.White;
            lblTotalTaskCount.Location = new Point(8, 47);
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
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(panelContainer);
            Controls.Add(panelHeaderDate);
            MinimumSize = new Size(450, 650);
            Name = "dashboardForm";
            Text = "dashboardForm";
            Load += dashboardForm_Load;
            ResizeEnd += dashboardForm_ResizeEnd;
            Resize += dashboardForm_Resize;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            panelDataGrid.ResumeLayout(false);
            panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelRecentActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            tableLayoutPanelAnalyticsRow.ResumeLayout(false);
            tableLayoutPanelAnalyticsRow.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            tableLayoutPanelSummaryCards.ResumeLayout(false);
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
        private Panel panelHeaderDate;
        private Panel panelContainer;
        private Panel panelDataGrid;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panelRecentActivity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private TableLayoutPanel tableLayoutPanelAnalyticsRow;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private TableLayoutPanel tableLayoutPanelSummaryCards;
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
    }
}