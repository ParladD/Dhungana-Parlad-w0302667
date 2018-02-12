 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerDataLayer
{
    public class Applications
    {
        /// <summary>
        /// this method will return all the application list
        /// </summary>
        /// <returns>apps, is the list of all the record on the Applicaiton Table</returns>
        public List<App> GetApplicationList()
        {
            List<App> apps = new List<App>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"GetApplication";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //executing the reader

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        App app = new App();
                        app.LoadApplication(reader);
                        apps.Add(app);


                   
                    }

                }
            }

            return apps;
        }//end getapplicationlist

        public void DeleteApplication(int AppID)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"DeleteApplication";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating new Parameter

                    SqlParameter parameter_AppID = new SqlParameter("AppID",System.Data.SqlDbType.Int);
                    parameter_AppID.Value = AppID;
                    command.Parameters.Add(parameter_AppID);

                    //executing the non query

                    command.ExecuteNonQuery();
                }
            }
        }// end delete application

        /// <summary>
        /// this method will update the the user id of the 
        /// </summary>
        /// <param name="AppID"></param>
        /// <param name="AppName"></param>
        /// <param name="AppVersion"></param>
        /// <param name="AppDesc"></param>
        public void UpdateApplication(int AppID, string AppName, string AppVersion, string AppDesc)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UpdateApplication";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating parameters

                    SqlParameter parameter_AppID = new SqlParameter("AppID", System.Data.SqlDbType.Int);
                    parameter_AppID.Value = AppID;
                    command.Parameters.Add(parameter_AppID);

                    SqlParameter parameter_AppName = new SqlParameter("AppName", System.Data.SqlDbType.VarChar, 40);
                    parameter_AppName.Value = AppName;
                    command.Parameters.Add(parameter_AppName);

                    SqlParameter parameter_AppVersion = new SqlParameter("AppVersion", System.Data.SqlDbType.VarChar, 40);
                    parameter_AppVersion.Value = AppVersion; 
                    command.Parameters.Add(parameter_AppVersion);

                    SqlParameter parameter_AppDesc = new SqlParameter("AppDesc", System.Data.SqlDbType.VarChar, 255);
                    parameter_AppDesc.Value = AppDesc;
                    command.Parameters.Add(parameter_AppDesc);

                    command.ExecuteNonQuery();

                }

            }
        }//end updateApplication


        /// <summary>
        /// 
        /// </summary>
        /// <param name="AppName"></param>
        /// <param name="AppVersion"></param>
        /// <param name="AppDesc"></param>

        public void InsertApplication(string AppName, string AppVersion, string AppDesc)
        {

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"InsertApplication";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating parameters

                    SqlParameter parameter_AppName = new SqlParameter("AppName", System.Data.SqlDbType.VarChar, 40);
                    parameter_AppName.Value = AppName;
                    command.Parameters.Add(parameter_AppName);

                    SqlParameter parameter_AppVersion = new SqlParameter("AppVersion", System.Data.SqlDbType.VarChar, 40);
                    parameter_AppVersion.Value = AppVersion;
                    command.Parameters.Add(parameter_AppVersion);

                    SqlParameter parameter_AppDesc = new SqlParameter("AppDesc", System.Data.SqlDbType.VarChar, 255);
                    parameter_AppDesc.Value = AppDesc;
                    command.Parameters.Add(parameter_AppDesc);

                    command.ExecuteNonQuery();

                }

            }
        }//end insert Application


    }//end Applications main



    public class App
    {
        public int ApplicationID { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationVersion { get; set; }
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// this will reade all the incoming data from the database and 
        /// converts it to the fields datatype for example string/int
        /// </summary>
        /// <param name="reader"> this will be used to read the data</param>
        public void LoadApplication(SqlDataReader reader)
        {
            ApplicationID = Int32.Parse(reader["AppID"].ToString());
            ApplicationName = reader["AppName"].ToString();
            ApplicationVersion = reader["AppVersion"].ToString();
            ApplicationDescription = reader["AppDesc"].ToString();

        }//end data reader


    }//end Application

}//end namespace
