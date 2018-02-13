using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerDataLayer
{
    public class DB
    {

        /// <summary>
        /// this method will configure the connectiong string to make nesscasry connection
        /// </summary>
        public static string ConnectionString
        {
            get{
                string connectionString = ConfigurationManager.ConnectionStrings["BugTracker"].ConnectionString;

                SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder(connectionString);
                stringBuilder.ApplicationName = ApplicationName ?? stringBuilder.ApplicationName;
                stringBuilder.ConnectTimeout = (ConnectionTimeout > 0) ? ConnectionTimeout : stringBuilder.ConnectTimeout;

                return stringBuilder.ToString();
            }


        }
        /// <summary>
        /// this methods returns sqlConnection 
        /// </summary>
        /// <returns>returns connection</returns>

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }


        /// <summary>
        /// Overrides the connection timeout
        /// </summary>
        public static int ConnectionTimeout { get; set; }

        /// <summary>
        /// Property used to override the name of the application
        /// </summary>
        public static string ApplicationName { get; set; }


    }
}


