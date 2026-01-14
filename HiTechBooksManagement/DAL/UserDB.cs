using HiTechBooksManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.DAL
{
    public static class UserDB
    {
        public static List<User> GetAllRecords()
        {
            string query = "SELECT * FROM Users ";

            // Create list of Users
            List<User>listUser = new List<User>();

            // Connect to DB
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdListAll = new SqlCommand(query, conn);
            SqlDataReader reader = cmdListAll.ExecuteReader();

            while (reader.Read())
            {
                User user = new User();
                user.UserID = Convert.ToInt32(reader["UserID"]);
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                user.RoleID = reader["RoleID"] != DBNull.Value ? Convert.ToInt32(reader["RoleID"]) : 0;
                user.IsActive = Convert.ToBoolean(reader["IsActive"]);
                user.Password = reader["Password"].ToString();
                listUser.Add(user);
            }
            conn.Close();
            return listUser;
        }

        public static List<User> GetOrderClerks()
        {

            string query = @"SELECT U.*
                            FROM Users U
                            JOIN Roles R ON U.RoleID = R.RoleID
                            WHERE R.RoleName = 'Order Clerk'
    ";

            List<User> listUser = new List<User>();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User user = new User();
                user.UserID = Convert.ToInt32(reader["UserID"]);
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                user.RoleID = reader["RoleID"] != DBNull.Value ? Convert.ToInt32(reader["RoleID"]) : 0;
                user.IsActive = Convert.ToBoolean(reader["IsActive"]);

                listUser.Add(user);
            }

            conn.Close();
            return listUser;
        }

        public static User SearchRecord(int userID)
        {
            User user = new User();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUserSearch = new SqlCommand();
            cmdUserSearch.Connection = conn;
            cmdUserSearch.CommandText = "SELECT * FROM Users " +
                                        "WHERE UserID = @UserID";
            cmdUserSearch.Parameters.AddWithValue("@UserID", userID);
            SqlDataReader reader = cmdUserSearch.ExecuteReader();
            if (reader.Read())
            {
                user.UserID = Convert.ToInt32(reader["UserID"]);
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                user.RoleID = Convert.ToInt32(reader["RoleID"]);
                user.IsActive = Convert.ToBoolean(reader["IsActive"]);
            }
            else
            {
                user = null;
            }
            conn.Close();
            return user;
        }

        public static User SearchRecorByUsername(string username)
        {
            User user = new User();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdUserSearch = new SqlCommand();
            cmdUserSearch.Connection = conn;
            cmdUserSearch.CommandText = "SELECT * FROM Users " +
                                        "WHERE Username = @Username";
            cmdUserSearch.Parameters.AddWithValue("@Username", username);
            SqlDataReader reader = cmdUserSearch.ExecuteReader();
            if (reader.Read())
            {
                user.UserID = Convert.ToInt32(reader["UserID"]);
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                user.RoleID = Convert.ToInt32(reader["RoleID"]);
                user.IsActive = Convert.ToBoolean(reader["IsActive"]);
            }
            else
            {
                user = null;
            }
            conn.Close();
            return user;
        }

        public static void SaveRecord(User user)
        {
            // Insert Query
            string insertQuery = "INSERT INTO Users (Username, Password, EmployeeID, RoleID, IsActive)" +
                                 "VALUES (@Username, @Password, @EmployeeID, @RoleID, @IsActive)";
            // Connect DB 
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = insertQuery;
            cmdInsert.Parameters.AddWithValue("@Username", user.Username);
            cmdInsert.Parameters.AddWithValue("@Password", user.Password);
            cmdInsert.Parameters.AddWithValue("@EmployeeID", user.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@RoleID", user.RoleID);
            cmdInsert.Parameters.AddWithValue("@IsActive", user.IsActive);
            cmdInsert.ExecuteNonQuery();

            // Close DB
            conn.Close();
        }

        public static bool UserExists(int userID)
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdEmpExists = new SqlCommand(query, conn);
            cmdEmpExists.Parameters.AddWithValue("@UserID", userID);

            SqlDataReader reader = cmdEmpExists.ExecuteReader();

            bool exists = false;
            while (reader.Read())
            {
                exists = true;
                break;
            }
            reader.Close();
            return exists;
        }

        public static void UpdateRecord(User user)
        {

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandText = "UPDATE Users " +
                                        " SET Username=@Username ," +
                                        "Password = @Password, " +
                                        "RoleID = @RoleID, " +
                                        "IsActive = @IsActive " +
                                        "WHERE UserID = @UserID";
                cmdUpdate.Parameters.AddWithValue("@Username", user.Username);
                cmdUpdate.Parameters.AddWithValue("@Password", user.Password);
                cmdUpdate.Parameters.AddWithValue("@RoleID", user.RoleID);
                cmdUpdate.Parameters.AddWithValue("@IsActive", user.IsActive);
                cmdUpdate.Parameters.AddWithValue("@UserID", user.UserID);
                cmdUpdate.ExecuteNonQuery();
            }
        }

        public static bool EmployeeHasUser(int employeeID)
        {
            string query = "SELECT * FROM Users WHERE EmployeeID = @EmployeeID";

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdEmpExists = new SqlCommand(query, conn);
            cmdEmpExists.Parameters.AddWithValue("@EmployeeID", employeeID);

            SqlDataReader reader = cmdEmpExists.ExecuteReader();

            bool exists = false;
            while (reader.Read())
            {
                exists = true;
                break;
            }
            reader.Close();
            return exists;
        }

        public static bool validCredentials(string username, string password)
        {
            username.Trim();

            string query = "SELECT * FROM Users WHERE Username = @Username and Password = @Password";

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdEmpExists = new SqlCommand(query, conn);
            cmdEmpExists.Parameters.AddWithValue("@Username", username);
            cmdEmpExists.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = cmdEmpExists.ExecuteReader();

            bool exists = false;
            while (reader.Read())
            {
                exists = true;
                break;
            }
            reader.Close();
            return exists;
        }

        public static string GetUserRole(string username)
        {
            username.Trim();
            string query = "SELECT R.RoleName FROM Users U " +
                           "JOIN Roles R ON U.RoleID = R.RoleID " +
                           "WHERE U.Username = @Username";
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetRole = new SqlCommand(query, conn);
            cmdGetRole.Parameters.AddWithValue("@Username", username);
            SqlDataReader reader = cmdGetRole.ExecuteReader();
            string roleName = string.Empty;
            if (reader.Read())
            {
                roleName = reader["RoleName"].ToString();
            }
            reader.Close();
            return roleName;
        }


    }
}
