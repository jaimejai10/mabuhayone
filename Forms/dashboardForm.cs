using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabuhayone
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {

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
            //ResponsiveEnd();
        }

        private void dashboardForm_Resize(object sender, EventArgs e)
        {
            ResponsiveEnd();
        }
    }
}
