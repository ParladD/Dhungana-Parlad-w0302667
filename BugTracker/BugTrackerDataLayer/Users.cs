﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerDataLayer
{
   public class Users
    {

        private int check;

        /// <summary>
        /// this will check if the user exists in the database for logon
        /// </summary>
        /// <param name="UserID">user id </param>
        /// <returns>if the uses exits than it will return all the detials about the user</returns>
        public int GetUserConfirmation(string UserName)
        {

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UserConfirmation"; 
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating a new sqlparameter and adding it to the list
                    SqlParameter Parameter_UserName = new SqlParameter("UserName", System.Data.SqlDbType.VarChar,80);
                    Parameter_UserName.Value = UserName;
                    command.Parameters.Add(Parameter_UserName);

                    SqlParameter Parameter_Exists= new SqlParameter("Exits", System.Data.SqlDbType.Int, 1);
                    Parameter_Exists.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(Parameter_Exists);

                    command.ExecuteNonQuery();
                  


                    check = (int)command.Parameters["Exits"].Value; //returns true or false based on the output value
                }

            }

            return check; //returning the user data


        }//end of userConfirmation



        /// <summary>
        /// THIS WILL RETURN ALL THE USERS FROM THE DATABASE
        /// </summary>
        /// <returns> returns a list of user by reading the data</returns>
        public List<User> GetUserList()
        {

            List<User> users = new List<User>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"GetUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        User u = new User();
                        u.LoadUsers(reader);
                        users.Add(u);
                    }
                }
            }

            return users;

        } // END USER LIST


        /// <summary>
        /// this will update the user depending on the user id
        /// </summary>
        /// <param name="UserID"> used for where caluse to determine the user</param>
        /// <param name="UserName">will be the name of the user</param>
        /// <param name="UserEmail">this is a user email</param>
        /// <param name="UserTel">this is a use telephone</param>

        public void UpdateUser(int UserID, string UserName, string UserEmail, string UserTel)
        {

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UpdateUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating parameters

                    SqlParameter parameter_UserID = new SqlParameter("UserID", System.Data.SqlDbType.Int);
                    parameter_UserID.Value = UserID;
                    command.Parameters.Add(parameter_UserID);

                    SqlParameter parameter_UserName = new SqlParameter("UserName", System.Data.SqlDbType.VarChar, 80);
                    parameter_UserName.Value = UserName;
                    command.Parameters.Add(parameter_UserName);

                    SqlParameter parameter_UserEmail = new SqlParameter("UserEmail", System.Data.SqlDbType.VarChar, 80);
                    parameter_UserEmail.Value = UserEmail;
                    command.Parameters.Add(parameter_UserEmail);

                    SqlParameter parameter_UserTel = new SqlParameter("UserTel", System.Data.SqlDbType.VarChar, 40);
                    parameter_UserTel.Value = UserTel;
                    command.Parameters.Add(parameter_UserTel);

                    command.ExecuteNonQuery();

                }

            }
        }//end update user


        /// <summary>
        /// this will delete a specific user record from the database 
        /// </summary>
        /// <param name="UserID"> the userid will be used to determine which user is to be deleted</param>
        public void DeleteUser(int UserID)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"DeleteUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating parameters

                    SqlParameter parameter_UserID = new SqlParameter("UserID", System.Data.SqlDbType.Int);
                    parameter_UserID.Value = UserID;
                    command.Parameters.Add(parameter_UserID);

                    //executing the query

                    command.ExecuteNonQuery();
                }
            }

        } //end Delete user method


        /// <summary>
        /// this method will be used to insert a new record of user to the database
        /// </summary>
        /// <param name="UserName">name of the user</param>
        /// <param name="UserEmail">users email</param>
        /// <param name="UserTel">user telephone</param>

        public void InserUser(string UserName, string UserEmail, string UserTel)
        {
            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"InsertUser";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //creating parameters
                    SqlParameter parameter_UserName = new SqlParameter("UserName", System.Data.SqlDbType.VarChar, 80);
                    parameter_UserName.Value = UserName;
                    command.Parameters.Add(parameter_UserName);

                    SqlParameter parameter_UserEmail = new SqlParameter("UserEmail", System.Data.SqlDbType.VarChar, 80);
                    parameter_UserEmail.Value = UserEmail;
                    command.Parameters.Add(parameter_UserEmail);

                    SqlParameter parameter_UserTel = new SqlParameter("UserTel", System.Data.SqlDbType.VarChar, 40);
                    parameter_UserTel.Value = UserTel;
                    command.Parameters.Add(parameter_UserTel);

                    //Executing the query
                    command.ExecuteNonQuery();
                }
            }
        }//end insert user



    }//end of the Users class

    public class User
    {
        /// <summary>
        /// gets and sets the UserID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// gets and sets the UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// gets and sets the UserEmail
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// gets and sets the UserTel
        /// </summary>
        public string UserTel { get; set; }
      
        /// <summary>
        /// this method loads all the data about the user with sql reader
        /// </summary>
        /// <param name="reader">sql data reader</param>
     public void LoadUsers(SqlDataReader reader)
        {
            UserID = Int32.Parse(reader["UserID"].ToString());
            UserName = reader["UserName"].ToString();
            UserEmail = reader["UserEmail"].ToString();
            UserTel = reader["UserTel"].ToString();
           
        }//end LOAD USERS

    }//END BUG
}//END BUGS
