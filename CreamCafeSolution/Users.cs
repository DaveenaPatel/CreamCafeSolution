using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreamCafeSolution
{
    internal class Users
    {
        public int UsersId { get; set; }
        public string UsersName { get; set; }
        public string UsersPassword { get; set; }
        public string UsersCafeName { get; set; }
        public string UsersFName { get; set; }
        public string UsersLName { get; set; }
        public string UsersEmail { get; set; }
        public string PhoneNumber { get; set; }

        public static string connection = ConfigurationManager.ConnectionStrings["CreamCafeSolution"].ConnectionString;

        public bool addUser(Users user)
        {
            int row;
            bool result = false;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Insert into Users (UsersName, UsersPassword, UsersCafeName, UsersFName, UsersLName, UsersEmail, PhoneNumber) Values " +
                    "(@UsersName, @UsersPassword, @UsersCafeName, @UsersFName, @UsersLName, @UsersEmail, @PhoneNumber)", con))
                {
                    cmd.Parameters.AddWithValue("@UsersName", user.UsersName);
                    cmd.Parameters.AddWithValue("@UsersPassword", user.UsersPassword);
                    cmd.Parameters.AddWithValue("@UsersCafeName", user.UsersCafeName);
                    cmd.Parameters.AddWithValue("@UsersFName", user.UsersFName);
                    cmd.Parameters.AddWithValue("@UsersLName", user.UsersLName);
                    cmd.Parameters.AddWithValue("@UsersEmail", user.UsersEmail);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);

                    row = cmd.ExecuteNonQuery();
                }
                if (row > 0) {
                    result = true;
                }
            }


            return result;
        }


    }
}
