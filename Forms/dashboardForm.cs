using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mabuhayone.Database;

namespace Mabuhayone
{
    public partial class dashboardForm : Form
    {
        private DateTime filterStartDate;
        private DateTime filterEndDate;

        public dashboardForm()
        {
            InitializeComponent();
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {

            LoadSummaryCards(); // ALWAYS GLOBAL

            SetFilter("Last7Days");
            //LoadPieChart();
            //LoadUserPerformance();
            //LoadWorkloadTrend();
            //LoadNotifications();
        }
        private void ResponsiveEnd()
        {
            if (this.Width <= 450)
            {
                tableLayoutPanelAnalyticsRow.ColumnStyles[1].Width = 350;
            }
            else if (this.Width < 1200)
            {
                tableLayoutPanelAnalyticsRow.ColumnStyles[1].Width = tableLayoutPanelAnalyticsRow.Width - (chart1.Width + chart1.Margin.Right);
            }
            else
            {
                tableLayoutPanelAnalyticsRow.ColumnStyles[1].Width = tableLayoutPanelAnalyticsRow.Width -
                    (chart1.Width + chart2.Width + chart1.Margin.Right + chart2.Margin.Right);
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

                string query = @"
                    SELECT
                        (SELECT COUNT(*) FROM tasks) AS total_tasks,
                        (SELECT COUNT(*) FROM tasks WHERE status = 'pending') AS pending_tasks,
                        (SELECT COUNT(*) FROM tasks WHERE status = 'in_progress') AS in_progress_tasks,
                        (SELECT COUNT(*) FROM tasks 
                         WHERE due_date < CURDATE() 
                         AND status <> 'completed') AS overdue_tasks;
                    ";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        DashboardCache.TotalTasks = reader.GetInt32("total_tasks");
                        DashboardCache.Pending = reader.GetInt32("pending_tasks");
                        DashboardCache.InProgress = reader.GetInt32("in_progress_tasks");
                        DashboardCache.Overdue = reader.GetInt32("overdue_tasks");
                    }
                }

                // TODAY TASKS (SAFE EXECUTION)
                string todayQuery = @"SELECT COUNT(*) FROM tasks WHERE DATE(created_at) = CURDATE();";

                MySqlCommand cmdToday = new MySqlCommand(todayQuery, conn);
                object result = cmdToday.ExecuteScalar();

                DashboardCache.TodayTasks = (result != null) ? Convert.ToInt32(result) : 0;

                DashboardCache.LastUpdated = DateTime.Now;

                ApplyCacheToUI();
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

                case "Last7Days":
                    filterStartDate = DateTime.Today.AddDays(-6);
                    filterEndDate = DateTime.Today;
                    break;

                case "ThisMonth":
                    filterStartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    filterEndDate = DateTime.Today;
                    break;

                case "ThisYear":
                    filterStartDate = new DateTime(DateTime.Today.Year, 1, 1);
                    filterEndDate = DateTime.Today;
                    break;
            }

            LoadSummaryCards();
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            SetFilter("ThisYear");
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {

        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            SetFilter("ThisMonth");
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            SetFilter("Yesterday");
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            SetFilter("Last7Days");
        }
    }
}
