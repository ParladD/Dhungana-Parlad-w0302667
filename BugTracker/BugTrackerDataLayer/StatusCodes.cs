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
        /// <summary>
        /// this method will return all the status code list
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// gets and sets StatusCodeID
        /// </summary>
        
        public int StatusCodeID { get; set; }
        /// <summary>
        /// gets and sets StatusCodeDescription
        /// </summary>
     
        public string StatusCodeDescription { get; set;}

        /// <summary>
        /// this method will load the staus by reading the incoming data using sqlDataReader
        /// </summary>
        /// <param name="reader"></param>
        public void LoadStatusCode(SqlDataReader reader)
        {
            StatusCodeID = Int32.Parse(reader["StatusCodeID"].ToString());
            StatusCodeDescription = reader["StatusCodeDesc"].ToString();
        }//end load status

    }

}//end namespace
