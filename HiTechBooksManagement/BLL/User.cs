using HiTechBooksManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.BLL
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private int employeeID;
        private int roleID;
        public bool isActive;

        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int EmployeeID { get; set; }

        public int RoleID { get ; set; }

        public bool IsActive { get; set; }

        public List<User> ListAllUsers() => UserDB.GetAllRecords();

        public User SearchUser(int userID) => UserDB.SearchRecord(userID);
        public void SaveUser(User user) => UserDB.SaveRecord(user);

        public void UpdateUser(User user) => UserDB.UpdateRecord(user);

        public List<User>ListOrderClerks() => UserDB.GetOrderClerks();

        public User SearchUserByUsername(string username) => UserDB.SearchRecorByUsername(username);
    }
}
