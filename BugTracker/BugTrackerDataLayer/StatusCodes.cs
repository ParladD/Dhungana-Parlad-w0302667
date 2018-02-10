using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerDataLayer
{
   public class StatusCodes
    {

        public List <StatusCode> GetStatusCodeList()
        {
            List<StatusCode> statusCodes = new List<StatusCode>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"GetStatusCode";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        StatusCode statusCode = new StatusCode();
                        statusCode.LoadStatusCode(reader);
                        statusCodes.Add(statusCode);
                    }

                }//end using sqlcommand

            
            }//end using sql conneciton

            return statusCodes;
        }


    }//end StatusCodesclass



    public class StatusCode {

        public int StatusCodeID { get; set; }
        public string StatusCodeDescription { get; set;}

        public void LoadStatusCode(SqlDataReader reader)
        {
            StatusCodeID = Int32.Parse(reader["StatusCodeID"].ToString());
            StatusCodeDescription = reader["StatusCodeDesc"].ToString();
        }

    }

}//end namespace
