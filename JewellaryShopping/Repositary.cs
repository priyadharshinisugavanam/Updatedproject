using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace JewellaryShopping
{
    class User
    {
        public string userID { get; set; }
        public string password { get; set; }
        public string conformPassword { get; set; }
        public string mailId { get; set; }
        public string role { get; set; }
        public string phoneNumber { get; set; }
        public User(string userID, string password, string phoneNumber, string mailId, string role)
        {
            this.userID = userID;
            this.password = password;
            this.mailId = mailId;
            this.phoneNumber = phoneNumber;
            this.role = role;
        }
        public User(string userID, string password, string role)
        {
            this.userID = userID;
            this.password = password;
            this.role = role;
        }
    }
    class Repositary
    {


        public int AddAdmin(SqlConnection sqlConnection, User user)
        {
            string sql = "AdminProcedure";

            using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                SqlParameter paramm = new SqlParameter();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                paramm.ParameterName = "@UserId";
                paramm.Value = user.userID;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@password";
                paramm.Value = user.password;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@MailId";
                paramm.Value = user.mailId;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 20;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@PhoneNumber";
                paramm.Value = user.phoneNumber;
                paramm.SqlDbType = SqlDbType.Char;
                paramm.Size = 13;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@Action";
                paramm.Value = 1;
                paramm.SqlDbType = SqlDbType.Int;
                paramm.Size = 18;
                sqlCommand.Parameters.Add(paramm);

                paramm = new SqlParameter();
                paramm.ParameterName = "@RoleOfMemeber";
                paramm.Value = user.role;
                paramm.SqlDbType = SqlDbType.VarChar;
                paramm.Size = 5;
                sqlCommand.Parameters.Add(paramm);

                sqlConnection.Open();
                int row = sqlCommand.ExecuteNonQuery();
                return row;

            }
        }
        public int Login(SqlConnection sqlConnection, User user)
        {
            
            
            using (SqlCommand sqlCommand = new SqlCommand("Select_UserProcedures", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@UserId";
                sqlParameter.Value = user.userID;
                sqlParameter.SqlDbType = SqlDbType.Char;
                sqlParameter.Size = 18;
                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@password";
                sqlParameter.Value = user.password;
                sqlParameter.SqlDbType = SqlDbType.Char;
                sqlParameter.Size = 18;
                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Action";
                sqlParameter.Value = 2;
                sqlParameter.SqlDbType = SqlDbType.Int;
                sqlParameter.Size = 18;
                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@RoleOfMemeber";
                sqlParameter.Value = user.role;
                sqlParameter.SqlDbType = SqlDbType.Char;
                sqlParameter.Size = 18;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                    return 1;
                else
                    return 0;
                          
                
            }
            

        }

    }
    class Connection
    {
        public static SqlConnection getDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}