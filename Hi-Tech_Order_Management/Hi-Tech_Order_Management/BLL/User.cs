using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management.DAL;

namespace Hi_Tech_Order_Management.BLL
{
    public class User
    {
        int userID;
        string password;
        string jobTitle;
        string userStatus;

        public int UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string UserStatus { get => userStatus; set => userStatus = value; }


        public static bool VerifyUser(int userId)
        {
            return UserDB.VerifyRecord(userId);
        }

        public static bool VerifyPassword(int userId, string pws)
        {
            return UserDB.VerifyRecord(userId, pws);
        }

        public static User ReadUserInfo(int userId)
        {
            return UserDB.ReadRecord(userId);
        }


    }
}
