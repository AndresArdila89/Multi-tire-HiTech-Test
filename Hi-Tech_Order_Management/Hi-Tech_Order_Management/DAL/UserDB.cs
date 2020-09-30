using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management.BLL;

namespace Hi_Tech_Order_Management.DAL
{
    public static class UserDB
    {
        public static  bool VerifyRecord(int userID)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            cmdSelect.CommandText = "SELECT * FROM Users WHERE UserId = @UserId";
            cmdSelect.Parameters.AddWithValue("@UserId", userID);

            cmdSelect.Connection = conn;

            SqlDataReader dataReader = cmdSelect.ExecuteReader();


            bool result;
            result = dataReader.Read();

            conn.Close();

            return result;

        }

        public static bool VerifyRecord(int userId, string pws)
        {
            
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            cmdSelect.CommandText = "SELECT * FROM Users WHERE UserId = @UserId AND Password = @Password";
            cmdSelect.Parameters.AddWithValue("@UserId", userId);
            cmdSelect.Parameters.AddWithValue("@Password", pws);

            cmdSelect.Connection = conn;

            SqlDataReader dataReader = cmdSelect.ExecuteReader();
            
            bool result;
            result = dataReader.Read();

            conn.Close();

            return result;
        }

        public static User ReadRecord(int userID)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();


            cmdSelect.CommandText = "SELECT * FROM Users WHERE UserId = @UserId";
            cmdSelect.Parameters.AddWithValue("@UserId", userID);

            cmdSelect.Connection = conn;

            SqlDataReader dataReader = cmdSelect.ExecuteReader();
         
                User tempUser = new User();
                tempUser.UserID = Convert.ToInt32(dataReader["UserId"]);
                tempUser.Password = dataReader["Password"].ToString();
                tempUser.JobTitle = dataReader["JobTitle"].ToString();
                tempUser.UserStatus = dataReader["Status"].ToString();

            conn.Close();
            return tempUser;

        }
    }
}
