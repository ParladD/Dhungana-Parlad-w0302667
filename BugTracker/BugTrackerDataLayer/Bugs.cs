﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerDataLayer
{
    class Bugs
    {
         public List<Bug> GetBugList()
        {
            List<Bug> bugs = new List<Bug>();
                
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"GetBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

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


        public void UpdateBug(int AppID, int UserID, int BugSignOff,
            DateTime BugDate, string BugDesc, string BugDetails, string RepSteps,
            DateTime FixDate, int BugID, int StatusCodeID)
        {

            using(SqlConnection connection = DB.GetSqlConnection())
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UpdateBug";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter parameter_AppID = new SqlParameter("AppID", System.Data.SqlDbType.Int);
                    parameter_AppID.Value = AppID ;
                    command.Parameters.Add(parameter_AppID);

                    SqlParameter parameter_UserID = new SqlParameter("UserID", System.Data.SqlDbType.Int);
                    parameter_UserID.Value = UserID;
                    command.Parameters.Add(parameter_UserID);

                    SqlParameter parameter_BugSignOff = new SqlParameter("BugSignOff", System.Data.SqlDbType.Int);
                    parameter_BugSignOff.Value = BugSignOff;
                    command.Parameters.Add(parameter_BugSignOff);

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



        public void InsertBug(int AppID, int UserID, int BugSignOff,
            DateTime BugDate, string BugDesc, string BugDetails, string RepSteps,
            DateTime FixDate)
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

                    SqlParameter parameter_BugSignOff = new SqlParameter("BugSignOff", System.Data.SqlDbType.Int);
                    parameter_BugSignOff.Value = BugSignOff;
                    command.Parameters.Add(parameter_BugSignOff);

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

                    SqlParameter parameter_FixDate = new SqlParameter("FixDate", System.Data.SqlDbType.DateTime);
                    parameter_FixDate.Value = FixDate;
                    command.Parameters.Add(parameter_FixDate);

                    command.ExecuteNonQuery();

                }
            }

        }


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


    }//end Bugs class


    class Bug
    {
        public int BugID { get; set; }
        public int BugAppID { get; set; }
        public int BugUserID { get; set; }
        public int BugSignOff { get; set; }
        public DateTime BugDate { get; set; }
        public string BugDesc { get; set; }
        public string BugDetails { get; set; }
        public string BugRepSteps { get; set; }
        public DateTime BugFixDate { get; set; }


        public void LoadBug(SqlDataReader reader)
        {
            BugID = Int32.Parse(reader["BugID"].ToString());
            BugAppID = Int32.Parse(reader["AppID"].ToString());
            BugUserID = Int32.Parse(reader["UserID"].ToString());
            BugSignOff = Int32.Parse(reader["BugSignOff"].ToString());
            BugDate = DateTime.Parse(reader["BugDate"].ToString());
            BugDesc = reader["BugDesc"].ToString();
            BugDetails = reader["BugDetails"].ToString();
            BugRepSteps = reader["RepSteps"].ToString();
            BugFixDate = DateTime.Parse(reader["FixDate"].ToString());
        }

    }//end Bug

}//End namespace