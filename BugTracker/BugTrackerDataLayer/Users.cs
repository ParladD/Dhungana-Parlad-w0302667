using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerDataLayer
{
    class Users
    {
        public List<User> GetUserList()
        {

            List<User> users = new List<User>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"GetAllEmployees";
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
        }

    }


    public class User
    {

        //public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserTel { get; set; }
      

        public void LoadUsers(SqlDataReader reader)
        {
            UserName = reader["UserName"].ToString();
            UserEmail = reader["UserEmail"].ToString();
            UserTel = reader["UserTel"].ToString();
           
        }

    }
}
