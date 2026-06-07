using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;



namespace Mabuhayone
{
    class DBConnection
    {


        private MySqlConnection? connection;

        private string server = "localhost";
        private string database = "task_management_db";
        private string uid = "root";
        private string password = "";

        public MySqlConnection GetConnection()
        {
            connection = new MySqlConnection(
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";"
            );

            return connection;
        }

        public bool OpenConnection(MySqlConnection conn)
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CloseConnection(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
