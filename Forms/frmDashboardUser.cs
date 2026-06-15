using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mabuhayone.Database;
using Mabuhayone.Sessions;
using MySql.Data.MySqlClient;

namespace Mabuhayone.Forms
{
    public partial class frmDashboardUser : Form
    {
        public frmDashboardUser()
        {
            InitializeComponent();
            LoadSummaryCards();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboardUser_Load(object sender, EventArgs e)
        {

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
            (SELECT COUNT(*) 
             FROM tasks 
             WHERE assigned_to = @userId) AS total_tasks,

            (SELECT COUNT(*) 
             FROM tasks 
             WHERE assigned_to = @userId 
             AND status = 'pending') AS pending_tasks,

            (SELECT COUNT(*) 
             FROM tasks 
             WHERE assigned_to = @userId 
             AND status = 'completed') AS completed_tasks,

            (SELECT COUNT(*) 
             FROM tasks 
             WHERE assigned_to = @userId 
             AND due_date < CURDATE() 
             AND status <> 'completed') AS overdue_tasks,

            (SELECT COUNT(*) 
             FROM tasks 
             WHERE assigned_to = @userId 
             AND DATE(created_at) = CURDATE()) AS today_tasks;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", UserSession.UserId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblTotalTaskCount.Text = reader["total_tasks"].ToString();
                        lblPendingCount.Text = reader["pending_tasks"].ToString();
                        lblCompleted.Text = reader["completed_tasks"].ToString();
                        lblOverdueCount.Text = reader["overdue_tasks"].ToString();
                        lblTodayTaskCount.Text = reader["today_tasks"].ToString();
                    }
                }
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

    }
}
