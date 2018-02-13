using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerDataLayer
{
    public class Bugs
    {

        /// <summary>
        /// the method will return the list of bug 
        /// </summary>
        /// <param name="AppID">app id</param>
        /// <param name="StatID">status id</param>
        /// <returns></returns>
        public List<Bug> GetBugList(int AppID, int StatID)
        {
            List<Bug> bugs = new List<Bug>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"GetBugList";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter parameter_AppID = new SqlParameter("AppID", System.Data.SqlDbType.Int);
                    parameter_AppID.Value = AppID;
                    command.Parameters.Add(parameter_AppID);

                    SqlParameter parameter_StatID = new SqlParameter("Status", System.Data.SqlDbType.Int);
                    parameter_StatID.Value = StatID;
                    command.Parameters.Add(parameter_StatID);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Bug b = new Bug();
                        b.LoadBugList(reader);
                        bugs.Add(b);
                    }
                }
            }


            return bugs;
        }//end getBug




        /// <summary>
        /// this method will return the specific bug using stored procedure
        /// </summary>
        /// <param name="bugID">bug id</param>
        /// <returns>returns list of bug</returns>
        public List<Bug> GetBug(int bugID)
        {
            List<Bug> bugs = new List<Bug>();
                
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"GetBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter parameter_BugID = new SqlParameter("BugID", System.Data.SqlDbType.Int);
                    parameter_BugID.Value = bugID;
                    command.Parameters.Add(parameter_BugID);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Bug b = new Bug();
                        b.LoadBug(reader);
                        bugs.Add(b);
                    }
                }
            }


            return bugs; 
        }//end getBug

        /// <summary>
        /// the datalayer will be used to update the bug dat
        /// </summary>
        /// <param name="UserID">user id</param>
        /// <param name="BugDesc">bug description</param>
        /// <param name="BugDetails">bug details</param>
        /// <param name="RepSteps">steps to fix the bug</param>
        /// <param name="FixDate">date when it is fixed</param>
        /// <param name="BugID">id of the bugs</param>
        /// <param name="StatusCodeID">and status of the bug</param>

        public void UpdateBug(int UserID,string BugDesc, string BugDetails, string RepSteps,
            DateTime FixDate, int BugID, int StatusCodeID)
        {

            using(SqlConnection connection = DB.GetSqlConnection())
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UpdateBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;



                    SqlParameter parameter_UserID = new SqlParameter("UserID", System.Data.SqlDbType.Int);
                    parameter_UserID.Value = UserID;
                    command.Parameters.Add(parameter_UserID);

                    SqlParameter parameter_BugDesc = new SqlParameter("BugDesc", System.Data.SqlDbType.VarChar, 40);
                    parameter_BugDesc.Value = BugDesc;
                    command.Parameters.Add(parameter_BugDesc);

                    SqlParameter parameter_BugDetails = new SqlParameter("BugDetails", System.Data.SqlDbType.Text);
                    parameter_BugDetails.Value = BugDetails;
                    command.Parameters.Add(parameter_BugDetails);

                    SqlParameter parameter_RepSteps = new SqlParameter("RepSteps", System.Data.SqlDbType.Text);
                    parameter_RepSteps.Value = RepSteps;
                    command.Parameters.Add(parameter_RepSteps);

                    SqlParameter parameter_FixDate = new SqlParameter("FixDate", System.Data.SqlDbType.DateTime);
                    parameter_FixDate.Value = FixDate;
                    command.Parameters.Add(parameter_FixDate);

                    SqlParameter parameter_BugID = new SqlParameter("BugID", System.Data.SqlDbType.Int);
                    parameter_BugID.Value = BugID;
                    command.Parameters.Add(parameter_BugID);

                    SqlParameter parameter_StatusCodeID = new SqlParameter("StatusCodeID", System.Data.SqlDbType.Int);
                    parameter_StatusCodeID.Value = StatusCodeID;
                    command.Parameters.Add(parameter_StatusCodeID);

                    command.ExecuteNonQuery();

                }
            }

        }//end UpdateBug


        /// <summary>
        /// this method will be called to insert a bug data 
        /// </summary>
        /// <param name="AppID">application id</param>
        /// <param name="UserID">user id </param>
        /// <param name="BugSignOff">user who signed off</param>
        /// <param name="BugDate">date the bug was assinged</param>
        /// <param name="BugDesc">bug description</param>
        /// <param name="BugDetails">details abou the bug</param>
        /// <param name="RepSteps">steps to solve th bug</param>
        /// <param name="BugLogDesc">bug log description / comments</param>
        /// <param name="statusCode">bug status id</param>
        public void InsertBug( int AppID, int UserID,
            DateTime BugDate, string BugDesc, string BugDetails, string RepSteps)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"InsertBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter parameter_AppID = new SqlParameter("AppID", System.Data.SqlDbType.Int);
                    parameter_AppID.Value = AppID;
                    command.Parameters.Add(parameter_AppID);

                    SqlParameter parameter_UserID = new SqlParameter("UserID", System.Data.SqlDbType.Int);
                    parameter_UserID.Value = UserID;
                    command.Parameters.Add(parameter_UserID);


                    SqlParameter parameter_BugDate = new SqlParameter("BugDate", System.Data.SqlDbType.DateTime);
                    parameter_BugDate.Value = BugDate;
                    command.Parameters.Add(parameter_BugDate);

                    SqlParameter parameter_BugDesc = new SqlParameter("BugDesc", System.Data.SqlDbType.VarChar, 40);
                    parameter_BugDesc.Value = BugDesc;
                    command.Parameters.Add(parameter_BugDesc);

                    SqlParameter parameter_BugDetails = new SqlParameter("BugDetails", System.Data.SqlDbType.Text);
                    parameter_BugDetails.Value = BugDetails;
                    command.Parameters.Add(parameter_BugDetails);

                    SqlParameter parameter_RepSteps = new SqlParameter("RepSteps", System.Data.SqlDbType.Text);
                    parameter_RepSteps.Value = RepSteps;
                    command.Parameters.Add(parameter_RepSteps);

                    command.ExecuteNonQuery();

                }
            }

        }

        /// <summary>
        /// this method will be used to delete the bug 
        /// </summary>
        /// <param name="BugID">bug id</param>
        public void DeleteBug(int BugID)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"DeleteBugs";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating new Parameter

                    SqlParameter parameter_BugID = new SqlParameter("BugID", System.Data.SqlDbType.Int);
                    parameter_BugID.Value = BugID;
                    command.Parameters.Add(parameter_BugID);

                    //executing the non query

                    command.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// this method will return the database for the sepecific bug
        /// </summary>
        /// <param name="bugid">bug id</param>
        /// <returns></returns>
        public static System.Data.DataTable GetLog(int bugid)
        {
            DataTable table = new DataTable("BugLog");

            SqlDataAdapter dataAdapter = null;

            using (SqlConnection connection = DB.GetSqlConnection())
            {

                using (SqlCommand command = connection.CreateCommand())

                {

                    command.CommandText = @"DataTableProcedure";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlParameter parameter_bugid = new SqlParameter("bugId", SqlDbType.Int);
                    parameter_bugid.Value = bugid;
                    command.Parameters.Add(parameter_bugid);

                    command.ExecuteNonQuery();
                    using (dataAdapter = new SqlDataAdapter(command))
                    {
                        int result = dataAdapter.Fill(table);
                    }

                }
            }
       
            return table;
        }



    }//end Bugs class


    public class Bug
    {
        /// <summary>
        /// gets and sets the bug id
        /// </summary>
        public int BugID { get; set; }
        /// <summary>
        /// gets ans sets the bug application id
        /// </summary>
        public int BugAppID { get; set; }
        /// <summary>
        /// gets and sets the bug user id
        /// </summary>
        public int BugUserID { get; set; }
        /// <summary>
        /// gets and sets the bug sign off id
        /// </summary>
        public int BugSignOff { get; set; }
        /// <summary>
        /// gets and sets the bug date
        /// </summary>
        public DateTime BugDate { get; set; }
        /// <summary>
        /// gets and sets the description of the bug
        /// </summary>
        public string BugDesc { get; set; }
        /// <summary>
        /// gets and sets the bug detailed info
        /// </summary>
        public string BugDetailInfo { get; set; }
        /// <summary>
        /// gets and sets the bug fixing steps
        /// </summary>
        public string BugRepStepInfo { get; set; }
        /// <summary>
        /// gets and sets the fixed date of the bug
        /// </summary>
        public DateTime BugFixDate { get; set; }

        /// <summary>
        /// this method will read the incoming data using sql data reader
        /// </summary>
        /// <param name="reader">sql data reader</param>
        public void LoadBugList(SqlDataReader reader)
        {
            BugID = Int32.Parse(reader["BugID"].ToString());
            BugAppID = Int32.Parse(reader["AppID"].ToString());
            BugUserID = Int32.Parse(reader["UserID"].ToString()); 
            BugDesc = reader["BugDesc"].ToString();
       
        }

        /// <summary>
        /// this method will read the incoming data using sql data reader
        /// </summary>
        /// <param name="reader">sql data reader</param>
        public void LoadBug(SqlDataReader reader)
        {
            LoadBugList(reader);
            BugDetailInfo = reader["BugDetails"].ToString();
            BugRepStepInfo = reader["RepSteps"].ToString();
            BugDate = DateTime.Parse(reader["BugDate"].ToString());
            BugFixDate = DateTime.Parse(reader["FixDate"].ToString());
           
        }


    }//end Bug

}//End namespace
