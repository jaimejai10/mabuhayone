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
using Org.BouncyCastle.Crypto.Generators;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Mabuhayone
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string username = txtUsername.Text;

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT * FROM users WHERE username = @username";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hashedPassword = reader["password"]?.ToString() ?? "";

                    bool isValidPassword = BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashedPassword);

                    if (isValidPassword)
                    {
                        // STORE SESSION
                        UserSession.UserId = Convert.ToInt32(reader["user_id"]);
                        UserSession.Username = reader["username"].ToString() ?? "";
                        UserSession.FullName = reader["full_name"].ToString() ?? "";
                        UserSession.Position = reader["position"].ToString() ?? "";
                        UserSession.Role = reader["role"].ToString() ?? "";

                        // OPEN MAIN FORM
                        this.Hide();

                        mainForm main = new mainForm();
                        main.Show();
                    }
                    else
                    {
                        lblError.Text = "Invalid username or password";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Invalid username or password";
                    lblError.Visible = true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "System error: " + ex.Message;
                lblError.Visible = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

    }
}
