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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardForm));
            panelHeaderDate = new Panel();
            lblFilterStatus = new Label();
            btnYesterday = new Button();
            btnCustomDate = new Button();
            btnLast7Days = new Button();
            btnThisMonth = new Button();
            btnThisYear = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            panelContainer = new Panel();
            panelDataGrid = new Panel();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panelRecentActivity = new Panel();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanelAnalyticsRow = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            chartSummaryReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTopServices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            label3 = new Label();
            dgvUserPerformance = new DataGridView();
            tableLayoutPanelSummaryCards = new TableLayoutPanel();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            lblOverdueCount = new Label();
            lblOverdue = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            lblInProgressCount = new Label();
            lblInProgress = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lblPendingCount = new Label();
            lblPending = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblTotalTaskCount = new Label();
            lblTotalTask = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTodayTask = new Label();
            lblTodayTaskCount = new Label();
            panelHeaderDate.SuspendLayout();
            panelContainer.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            tableLayoutPanelAnalyticsRow.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSummaryReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTopServices).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserPerformance).BeginInit();
            tableLayoutPanelSummaryCards.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeaderDate
            // 
            panelHeaderDate.Controls.Add(lblFilterStatus);
            panelHeaderDate.Controls.Add(btnYesterday);
            panelHeaderDate.Controls.Add(btnCustomDate);
            panelHeaderDate.Controls.Add(btnLast7Days);
            panelHeaderDate.Controls.Add(btnThisMonth);
            panelHeaderDate.Controls.Add(btnThisYear);
            panelHeaderDate.Controls.Add(dtpEndDate);
            panelHeaderDate.Controls.Add(dtpStartDate);
            panelHeaderDate.Dock = DockStyle.Top;
            panelHeaderDate.Location = new Point(0, 0);
            panelHeaderDate.Name = "panelHeaderDate";
            panelHeaderDate.Size = new Size(1184, 34);
            panelHeaderDate.TabIndex = 2;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.Anchor = AnchorStyles.Right;
            lblFilterStatus.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterStatus.ForeColor = SystemColors.WindowFrame;
            lblFilterStatus.Location = new Point(255, 6);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(291, 23);
            lblFilterStatus.TabIndex = 7;
            lblFilterStatus.Text = "Filter Status";
            lblFilterStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnYesterday
            // 
            btnYesterday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnYesterday.FlatAppearance.BorderColor = Color.DimGray;
            btnYesterday.FlatStyle = FlatStyle.Flat;
            btnYesterday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnYesterday.ForeColor = SystemColors.WindowFrame;
            btnYesterday.Location = new Point(862, 5);
            btnYesterday.Name = "btnYesterday";
            btnYesterday.Size = new Size(75, 23);
            btnYesterday.TabIndex = 6;
            btnYesterday.Text = "Yesterday";
            btnYesterday.UseVisualStyleBackColor = true;
            btnYesterday.Click += btnYesterday_Click;
            // 
            // btnCustomDate
            // 
            btnCustomDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCustomDate.FlatAppearance.BorderColor = Color.DimGray;
            btnCustomDate.FlatStyle = FlatStyle.Flat;
            btnCustomDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCustomDate.ForeColor = SystemColors.WindowFrame;
            btnCustomDate.Location = new Point(774, 5);
            btnCustomDate.Name = "btnCustomDate";
            btnCustomDate.Size = new Size(88, 23);
            btnCustomDate.TabIndex = 5;
            btnCustomDate.Text = "Custom Date";
            btnCustomDate.UseVisualStyleBackColor = true;
            btnCustomDate.Click += btnCustomDate_Click;
            // 
            // btnLast7Days
            // 
            btnLast7Days.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLast7Days.FlatAppearance.BorderColor = Color.DimGray;
            btnLast7Days.FlatStyle = FlatStyle.Flat;
            btnLast7Days.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLast7Days.ForeColor = SystemColors.WindowFrame;
            btnLast7Days.Location = new Point(937, 5);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(75, 23);
            btnLast7Days.TabIndex = 4;
            btnLast7Days.Text = "This Week";
            btnLast7Days.UseVisualStyleBackColor = true;
            btnLast7Days.Click += btnThisWeek_Click;
            // 
            // btnThisMonth
            // 
            btnThisMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThisMonth.FlatAppearance.BorderColor = Color.DimGray;
            btnThisMonth.FlatStyle = FlatStyle.Flat;
            btnThisMonth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThisMonth.ForeColor = SystemColors.WindowFrame;
            btnThisMonth.Location = new Point(1012, 5);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(92, 23);
            btnThisMonth.TabIndex = 3;
            btnThisMonth.Text = "This Month";
            btnThisMonth.UseVisualStyleBackColor = true;
            btnThisMonth.Click += btnThisMonth_Click;
            // 
            // btnThisYear
            // 
            btnThisYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThisYear.FlatAppearance.BorderColor = Color.DimGray;
            btnThisYear.FlatStyle = FlatStyle.Flat;
            btnThisYear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThisYear.ForeColor = SystemColors.WindowFrame;
            btnThisYear.Location = new Point(1104, 5);
            btnThisYear.Name = "btnThisYear";
            btnThisYear.Size = new Size(75, 23);
            btnThisYear.TabIndex = 2;
            btnThisYear.Text = "This Year";
            btnThisYear.UseVisualStyleBackColor = true;
            btnThisYear.Click += btnThisYear_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpEndDate.CustomFormat = "MMM dd, yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(663, 5);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(105, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpStartDate.CalendarForeColor = SystemColors.WindowFrame;
            dtpStartDate.CalendarTitleForeColor = SystemColors.WindowFrame;
            dtpStartDate.CustomFormat = "MMM dd, yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(552, 5);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(105, 23);
            dtpStartDate.TabIndex = 0;
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
            panelContainer.Location = new Point(0, 34);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(10);
            panelContainer.Size = new Size(1184, 727);
            panelContainer.TabIndex = 7;
            // 
            // panelDataGrid
            // 
            panelDataGrid.BackColor = Color.White;
            panelDataGrid.Controls.Add(label2);
            panelDataGrid.Controls.Add(label1);
            panelDataGrid.Controls.Add(dataGridView1);
            panelDataGrid.Dock = DockStyle.Top;
            panelDataGrid.Location = new Point(10, 361);
            panelDataGrid.Margin = new Padding(0);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(947, 374);
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
            dataGridView1.Size = new Size(935, 333);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelRecentActivity
            // 
            panelRecentActivity.Controls.Add(chart4);
            panelRecentActivity.Dock = DockStyle.Right;
            panelRecentActivity.Location = new Point(957, 361);
            panelRecentActivity.Name = "panelRecentActivity";
            panelRecentActivity.Padding = new Padding(10, 0, 0, 0);
            panelRecentActivity.Size = new Size(200, 364);
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
            chart4.Size = new Size(190, 364);
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
            tableLayoutPanelAnalyticsRow.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanelAnalyticsRow.Dock = DockStyle.Top;
            tableLayoutPanelAnalyticsRow.Location = new Point(10, 100);
            tableLayoutPanelAnalyticsRow.Name = "tableLayoutPanelAnalyticsRow";
            tableLayoutPanelAnalyticsRow.RowCount = 1;
            tableLayoutPanelAnalyticsRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAnalyticsRow.Size = new Size(1147, 261);
            tableLayoutPanelAnalyticsRow.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(chartSummaryReport);
            flowLayoutPanel1.Controls.Add(chartTopServices);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(797, 261);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // chartSummaryReport
            // 
            chartArea2.Name = "ChartArea1";
            chartSummaryReport.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend1";
            chartSummaryReport.Legends.Add(legend2);
            chartSummaryReport.Location = new Point(0, 0);
            chartSummaryReport.Margin = new Padding(0, 0, 10, 10);
            chartSummaryReport.Name = "chartSummaryReport";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartSummaryReport.Series.Add(series2);
            chartSummaryReport.Size = new Size(300, 250);
            chartSummaryReport.TabIndex = 0;
            chartSummaryReport.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Summary Chart";
            chartSummaryReport.Titles.Add(title1);
            // 
            // chartTopServices
            // 
            chartArea3.Name = "ChartArea1";
            chartTopServices.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartTopServices.Legends.Add(legend3);
            chartTopServices.Location = new Point(310, 0);
            chartTopServices.Margin = new Padding(0, 0, 10, 10);
            chartTopServices.Name = "chartTopServices";
            chartTopServices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartTopServices.Series.Add(series3);
            chartTopServices.Size = new Size(300, 250);
            chartTopServices.TabIndex = 1;
            chartTopServices.Text = "chart2";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dgvUserPerformance);
            groupBox1.Location = new Point(797, 0);
            groupBox1.Margin = new Padding(0, 0, 0, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 251);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Performance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 223);
            label3.Name = "label3";
            label3.Size = new Size(287, 15);
            label3.TabIndex = 1;
            label3.Text = "GOOD (80–100%) | AVERAGE (50–79%) | LOW (0–49%)";
            // 
            // dgvUserPerformance
            // 
            dgvUserPerformance.AllowUserToAddRows = false;
            dgvUserPerformance.AllowUserToDeleteRows = false;
            dgvUserPerformance.AllowUserToResizeColumns = false;
            dgvUserPerformance.AllowUserToResizeRows = false;
            dgvUserPerformance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserPerformance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserPerformance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe MDL2 Assets", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUserPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUserPerformance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUserPerformance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUserPerformance.GridColor = Color.FromArgb(98, 102, 244);
            dgvUserPerformance.Location = new Point(6, 22);
            dgvUserPerformance.Name = "dgvUserPerformance";
            dgvUserPerformance.ReadOnly = true;
            dgvUserPerformance.RowHeadersVisible = false;
            dgvUserPerformance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserPerformance.Size = new Size(338, 195);
            dgvUserPerformance.TabIndex = 0;
            dgvUserPerformance.CellContentClick += dgvUserPerformance_CellContentClick;
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
            tableLayoutPanelSummaryCards.Size = new Size(1147, 90);
            tableLayoutPanelSummaryCards.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(lblOverdueCount);
            panel5.Controls.Add(lblOverdue);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(916, 0);
            panel5.Margin = new Padding(0, 0, 0, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 80);
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
            lblOverdueCount.Location = new Point(82, 47);
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(98, 102, 244);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblInProgressCount);
            panel4.Controls.Add(lblInProgress);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(687, 0);
            panel4.Margin = new Padding(0, 0, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 80);
            panel4.TabIndex = 3;
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
            // lblInProgressCount
            // 
            lblInProgressCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInProgressCount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInProgressCount.ForeColor = Color.White;
            lblInProgressCount.Location = new Point(82, 47);
            lblInProgressCount.Name = "lblInProgressCount";
            lblInProgressCount.Size = new Size(134, 25);
            lblInProgressCount.TabIndex = 1;
            lblInProgressCount.Text = "00";
            lblInProgressCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInProgress.ForeColor = Color.White;
            lblInProgress.Location = new Point(74, 4);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(129, 20);
            lblInProgress.TabIndex = 0;
            lblInProgress.Text = "Total In Progress";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 74, 130);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblPendingCount);
            panel3.Controls.Add(lblPending);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(458, 0);
            panel3.Margin = new Padding(0, 0, 10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 80);
            panel3.TabIndex = 2;
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
            // panel2
            // 
            panel2.BackColor = Color.Orchid;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTotalTaskCount);
            panel2.Controls.Add(lblTotalTask);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(229, 0);
            panel2.Margin = new Padding(0, 0, 10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 80);
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
            lblTotalTaskCount.Location = new Point(81, 47);
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
            panel1.Size = new Size(219, 80);
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
            lblTodayTaskCount.Location = new Point(80, 47);
            lblTodayTaskCount.Name = "lblTodayTaskCount";
            lblTodayTaskCount.Size = new Size(138, 25);
            lblTodayTaskCount.TabIndex = 1;
            lblTodayTaskCount.Text = "00";
            lblTodayTaskCount.TextAlign = ContentAlignment.MiddleRight;
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
            Text = "DASHBOARD";
            Load += dashboardForm_Load;
            ResizeEnd += dashboardForm_ResizeEnd;
            Resize += dashboardForm_Resize;
            panelHeaderDate.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)chartSummaryReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTopServices).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserPerformance).EndInit();
            tableLayoutPanelSummaryCards.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopServices;
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
        private DateTimePicker dtpEndDate;
        private Button btnCustomDate;
        private Button btnLast7Days;
        private Button btnThisMonth;
        private Button btnThisYear;
        private Button btnYesterday;
        private Label lblFilterStatus;
        private GroupBox groupBox1;
        private DataGridView dgvUserPerformance;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSummaryReport;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private DateTimePicker dtpStartDate;
    }
}