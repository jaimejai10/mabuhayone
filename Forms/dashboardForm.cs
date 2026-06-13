using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Mabuhayone.Database;
using MySql.Data.MySqlClient;

namespace Mabuhayone
{
    public partial class dashboardForm : Form
    {
        private bool isFilterActive = false;
        private DateTime filterStartDate;
        private DateTime filterEndDate;

        public dashboardForm()
        {
            InitializeComponent();
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {
            isFilterActive = false;

            LoadSummaryCards();
            LoadUserPerformance();
            LoadPieChart();
            LoadTopRequestedService();
            LoadTasks();

        }
        private void ResponsiveEnd()
        {
            if (this.Width <= 450)
            {
                tableLayoutPanelAnalyticsRow.ColumnStyles[1].Width = 350;
            }
            else if (this.Width < 1200)
            {
                tableLayoutPanelAnalyticsRow.ColumnStyles[1].Width = tableLayoutPanelAnalyticsRow.Width - (chartSummaryReport.Width + chartSummaryReport.Margin.Right);
            }
            else
            {
                tableLayoutPanelAnalyticsRow.ColumnStyles[1].Width = tableLayoutPanelAnalyticsRow.Width -
                    (chartSummaryReport.Width + chartTopServices.Width + chartSummaryReport.Margin.Right + chartTopServices.Margin.Right);
            }
            if (this.Height <= 800)
            {
                panelDataGrid.Height = 290;
            }
            else
            {
                panelDataGrid.Height = panelRecentActivity.Height;
            }
        }

        private void dashboardForm_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void dashboardForm_Resize(object sender, EventArgs e)
        {
            ResponsiveEnd();
        }

        private void LoadSummaryCards()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query;

                if (!isFilterActive)
                {
                    // OVERALL DASHBOARD
                    query = @"
            SELECT
                (SELECT COUNT(*) FROM tasks) AS total_tasks,

                (SELECT COUNT(*) FROM tasks
                 WHERE status = 'pending') AS pending_tasks,

                (SELECT COUNT(*) FROM tasks
                 WHERE status = 'in_progress') AS in_progress_tasks,

                (SELECT COUNT(*) FROM tasks
                 WHERE due_date < CURDATE()
                 AND status <> 'completed') AS overdue_tasks;
            ";
                }
                else
                {
                    // FILTERED DASHBOARD
                    query = @"
            SELECT
                (SELECT COUNT(*) FROM tasks
                 WHERE DATE(created_at) BETWEEN @start AND @end) AS total_tasks,

                (SELECT COUNT(*) FROM tasks
                 WHERE status = 'pending'
                 AND DATE(created_at) BETWEEN @start AND @end) AS pending_tasks,

                (SELECT COUNT(*) FROM tasks
                 WHERE status = 'in_progress'
                 AND DATE(created_at) BETWEEN @start AND @end) AS in_progress_tasks,

                (SELECT COUNT(*) FROM tasks
                 WHERE due_date < CURDATE()
                 AND status <> 'completed'
                 AND DATE(created_at) BETWEEN @start AND @end) AS overdue_tasks;
            ";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (isFilterActive)
                {
                    cmd.Parameters.AddWithValue("@start", filterStartDate.Date);
                    cmd.Parameters.AddWithValue("@end", filterEndDate.Date);
                }

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DashboardCache.TotalTasks = Convert.ToInt32(reader["total_tasks"]);
                        DashboardCache.Pending = Convert.ToInt32(reader["pending_tasks"]);
                        DashboardCache.InProgress = Convert.ToInt32(reader["in_progress_tasks"]);
                        DashboardCache.Overdue = Convert.ToInt32(reader["overdue_tasks"]);
                    }
                }

                // TODAY TASKS ALWAYS TODAY
                string todayQuery = @"
        SELECT COUNT(*)
        FROM tasks
        WHERE DATE(created_at) = CURDATE();
        ";

                MySqlCommand cmdToday = new MySqlCommand(todayQuery, conn);

                object result = cmdToday.ExecuteScalar();

                DashboardCache.TodayTasks =
                    result != null ? Convert.ToInt32(result) : 0;

                DashboardCache.LastUpdated = DateTime.Now;

                ApplyCacheToUI();
                LoadPieChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ApplyCacheToUI()
        {
            lblTotalTaskCount.Text = DashboardCache.TotalTasks.ToString();
            lblTodayTaskCount.Text = DashboardCache.TodayTasks.ToString();
            lblPendingCount.Text = DashboardCache.Pending.ToString();
            lblInProgressCount.Text = DashboardCache.InProgress.ToString();
            lblOverdueCount.Text = DashboardCache.Overdue.ToString();
        }

        private void SetFilter(string type)
        {
            DateTime today = DateTime.Today;

            switch (type)
            {
                case "Today":
                    filterStartDate = DateTime.Today;
                    filterEndDate = DateTime.Today;
                    break;

                case "Yesterday":
                    filterStartDate = DateTime.Today.AddDays(-1);
                    filterEndDate = DateTime.Today.AddDays(-1);
                    break;

                case "ThisWeek":

                    int diff = (int)today.DayOfWeek;
                    if (diff == 0) diff = 7; // fix Sunday

                    filterStartDate = today.AddDays(-(diff - 1)); // Monday
                    filterEndDate = today; // up to today
                    break;

                case "ThisMonth":

                    filterStartDate = new DateTime(today.Year, today.Month, 1);
                    filterEndDate = today;
                    break;

                case "ThisYear":
                    filterStartDate = new DateTime(today.Year, 1, 1);
                    filterEndDate = today;
                    break;

            }

            LoadSummaryCards();
            LoadUserPerformance();
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            isFilterActive = true;
            SetFilter("ThisYear");
            lblFilterStatus.Text = "This Year";
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                MessageBox.Show(
                    "Start Date cannot be greater than End Date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            isFilterActive = true;

            filterStartDate = dtpStartDate.Value.Date;
            filterEndDate = dtpEndDate.Value.Date;

            lblFilterStatus.Text = $"Custom: {filterStartDate:yyyy-MM-dd} to {filterEndDate:yyyy-MM-dd}";

            LoadSummaryCards();
            LoadUserPerformance();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            isFilterActive = true;
            SetFilter("ThisMonth");
            lblFilterStatus.Text = "This Month";
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            isFilterActive = true;
            SetFilter("Yesterday");
            lblFilterStatus.Text = "Yesterday";
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            isFilterActive = true;
            SetFilter("ThisWeek");
            //MessageBox.Show("Start: " + filterStartDate.ToString("yyyy-MM-dd") +"\nEnd: " + filterEndDate.ToString("yyyy-MM-dd"));
            lblFilterStatus.Text = "This Week";
        }


        private void LoadUserPerformance()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = @"
                    SELECT 
                        u.full_name AS Employee,
                        COUNT(t.task_id) AS TotalTasks,
                        SUM(CASE WHEN t.status = 'completed' THEN 1 ELSE 0 END) AS Completed,
                        SUM(CASE WHEN t.status = 'in_progress' THEN 1 ELSE 0 END) AS InProgress,
                        SUM(CASE WHEN t.status = 'pending' THEN 1 ELSE 0 END) AS Pending,
                        ROUND(
                            (SUM(CASE WHEN t.status = 'completed' THEN 1 ELSE 0 END) / NULLIF(COUNT(t.task_id),0)) * 100,
                            0
                        ) AS CompletionRate
                    FROM tasks t
                    INNER JOIN users u ON u.user_id = t.assigned_to
                    WHERE (@start IS NULL OR t.created_at BETWEEN @start AND @end)
                    GROUP BY u.user_id, u.full_name
                    ORDER BY CompletionRate DESC;
                ";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (isFilterActive)
                {
                    cmd.Parameters.AddWithValue("@start", filterStartDate.Date);
                    cmd.Parameters.AddWithValue("@end", filterEndDate.Date);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@start", DBNull.Value);
                    cmd.Parameters.AddWithValue("@end", DBNull.Value);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvUserPerformance.DataSource = dt;

                // IMPORTANT: ensure event is attached only once
                dgvUserPerformance.CellPainting -= dgvUserPerformance_CellPainting;
                dgvUserPerformance.CellPainting += dgvUserPerformance_CellPainting;

                foreach (DataGridViewColumn col in dgvUserPerformance.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvUserPerformance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvUserPerformance.Columns["Employee"].FillWeight = 200;
                dgvUserPerformance.Columns["TotalTasks"].FillWeight = 80;
                dgvUserPerformance.Columns["Completed"].FillWeight = 80;
                dgvUserPerformance.Columns["InProgress"].FillWeight = 80;
                dgvUserPerformance.Columns["Pending"].FillWeight = 80;
                dgvUserPerformance.Columns["CompletionRate"].FillWeight = 120;

                dgvUserPerformance.ClearSelection();
                dgvUserPerformance.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Performance Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvUserPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPieChart()
        {
            chartSummaryReport.Series.Clear();
            chartSummaryReport.Titles.Clear();

            chartSummaryReport.Titles.Add("Task Summary Overview");

            Series series = new Series("Tasks");
            series.ChartType = SeriesChartType.Pie;

            int total = DashboardCache.TotalTasks;
            int today = DashboardCache.TodayTasks;
            int pending = DashboardCache.Pending;
            int inProgress = DashboardCache.InProgress;
            int overdue = DashboardCache.Overdue;

            series.Points.AddXY("Total Tasks", total);
            series.Points.AddXY("Today Tasks", today);
            series.Points.AddXY("Pending", pending);
            series.Points.AddXY("In Progress", inProgress);
            series.Points.AddXY("Overdue", overdue);

            // =========================
            // REMOVE NUMBERS / LABELS
            // =========================
            series.IsValueShownAsLabel = false;
            series.Label = "";

            // COLORS (HEX STYLE)
            series.Points[0].Color = ColorTranslator.FromHtml("#DA70D6");
            series.Points[1].Color = ColorTranslator.FromHtml("#00CED1");
            series.Points[2].Color = ColorTranslator.FromHtml("#FF4A82");
            series.Points[3].Color = ColorTranslator.FromHtml("#6266F4");
            series.Points[4].Color = ColorTranslator.FromHtml("#00BEFF");

            chartSummaryReport.Series.Add(series);

            chartSummaryReport.Legends[0].Enabled = true;

            series["PieLabelStyle"] = "Disabled"; // extra safety
        }

        private void LoadTopRequestedService()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = @"
            SELECT 
                UPPER(TRIM(category)) AS Service,
                COUNT(task_id) AS TotalRequests
            FROM tasks
            WHERE category IS NOT NULL 
              AND TRIM(category) <> ''
              AND UPPER(TRIM(category)) <> 'OTHERS'
            GROUP BY UPPER(TRIM(category))
            ORDER BY TotalRequests DESC
            LIMIT 5;
        ";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chartTopServices.Series.Clear();
                chartTopServices.ChartAreas.Clear();
                chartTopServices.Titles.Clear();

                // Title (kept clean)
                chartTopServices.Titles.Add("Top Requested Services");
                chartTopServices.Titles[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);
                chartTopServices.Titles[0].Alignment = ContentAlignment.TopCenter;

                ChartArea area = new ChartArea();
                chartTopServices.ChartAreas.Add(area);

                area.AxisX.Interval = 1;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.Enabled = false;

                area.AxisX.IsMarginVisible = true;

                Series series = new Series();
                series.ChartType = SeriesChartType.Bar;
                series.IsValueShownAsLabel = true;
                series.IsXValueIndexed = true;

                series.LabelForeColor = Color.Black;
                series.Font = new Font("Segoe UI", 9);

                chartTopServices.Series.Add(series);

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(
                        row["Service"].ToString(),
                        Convert.ToInt32(row["TotalRequests"])
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chart Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUserPerformance_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvUserPerformance.Columns[e.ColumnIndex].Name == "CompletionRate")
            {
                e.PaintBackground(e.CellBounds, true);

                int value = 0;
                int.TryParse(
                    dgvUserPerformance.Rows[e.RowIndex]
                    .Cells["CompletionRate"].Value?.ToString(),
                    out value
                );

                value = Math.Max(0, Math.Min(100, value));

                // background bar
                Rectangle barBack = new Rectangle(
                    e.CellBounds.X + 5,
                    e.CellBounds.Y + 8,
                    e.CellBounds.Width - 10,
                    12
                );

                using (Brush bg = new SolidBrush(Color.LightGray))
                {
                    e.Graphics.FillRectangle(bg, barBack);
                }

                // fill bar
                Rectangle barFill = new Rectangle(
                    e.CellBounds.X + 5,
                    e.CellBounds.Y + 8,
                    (int)((barBack.Width) * (value / 100f)),
                    12
                );

                Color color =
                    value >= 80 ? Color.SeaGreen :
                    value >= 50 ? Color.Orange :
                                  Color.IndianRed;

                using (Brush br = new SolidBrush(color))
                {
                    e.Graphics.FillRectangle(br, barFill);
                }



                // text %

                using (Font font = new Font("Segoe UI", 8, FontStyle.Regular))
                {
                    TextRenderer.DrawText(
                        e.Graphics,
                        value + "%",
                        font,
                        e.CellBounds,
                        Color.Black,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                    );
                }

                e.Handled = true;
            }
        }
        private void LoadTasks()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = @"
            SELECT 
                t.report_id AS TaskID,
                t.title AS Title,
                u.full_name AS AssignedTo,
                t.status AS Status,
                t.company_name AS CompanyName
            FROM tasks t
            INNER JOIN users u ON u.user_id = t.assigned_id
            ORDER BY t.report_id DESC;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTasks.DataSource = dt;

                // disable sorting
                foreach (DataGridViewColumn col in dgvTasks.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                // auto size columns
                dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // column sizing
                if (dgvTasks.Columns["TaskID"] != null)
                    dgvTasks.Columns["TaskID"].FillWeight = 70;

                if (dgvTasks.Columns["Title"] != null)
                    dgvTasks.Columns["Title"].FillWeight = 200;

                if (dgvTasks.Columns["AssignedTo"] != null)
                    dgvTasks.Columns["AssignedTo"].FillWeight = 150;

                if (dgvTasks.Columns["Status"] != null)
                    dgvTasks.Columns["Status"].FillWeight = 100;

                if (dgvTasks.Columns["CompanyName"] != null)
                    dgvTasks.Columns["CompanyName"].FillWeight = 150;

                dgvTasks.ClearSelection();
                dgvTasks.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Task Load Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
