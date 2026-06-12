using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabuhayone.Database
{
    internal class DashboardCache
    {
        public static int TotalTasks { get; set; }
        public static int TodayTasks { get; set; }
        public static int Pending { get; set; }
        public static int InProgress { get; set; }
        public static int Overdue { get; set; }

        public static int Complete { get; set; }
        public static DateTime LastUpdated { get; set; } = DateTime.MinValue;
    }
}
