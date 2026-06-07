using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Mabuhayone.Database;
using Mabuhayone.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mabuhayone
{
    public partial class mainForm : Form
    {

        private Size formSize;
        private string username;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public mainForm(string username)
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(92, 102, 244);
            formSize = this.ClientSize;
            this.username = username;
            CollapseMenu();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Navigation
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {

        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = " " + (menuButton.Tag?.ToString() ?? "");
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginForm login = new loginForm();
            login.Show();
        }

        private void lblFullname_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, iconButton1.Width, iconButton1.Height);
            iconButton1.Region = new Region(path);

            fetchusers();
        }
        private void fetchusers()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT full_name, position FROM users WHERE username = @username";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username.Trim());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string fullname = reader["full_name"]?.ToString() ?? "No Name";
                    string position = reader["position"]?.ToString() ?? "No Position";
                    lblFullname.Text = fullname;
                    lblPosition.Text = position;
                }
                else
                {
                    lblFullname.Text = "User not found";
                    lblPosition.Text = "User not found";
                }

                conn.Close();
            }
            catch
            {
                lblFullname.Text = "Error loading user";
                lblPosition.Text = "Error loading user";
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);//nav color highlight
            OpenChildForm(new dashboardForm());
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);//nav color highlight
            OpenChildForm(new taskForm());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);//nav color highlight
        }

        //Navigation Design

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.DarkSlateBlue;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(98, 102, 244);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }//Navigation Design end


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
        //End
        childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumBlue;
            lblTitleChildForm.Text = "Home";
        }
    }
}
