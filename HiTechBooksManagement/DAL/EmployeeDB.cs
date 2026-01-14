using HiTechBooksManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HiTechBooksManagement.DAL
{
    public static class EmployeeDB
    {
        public static List<Employee> GetAllRecords()
        {
            string query = "SELECT * FROM Employees";
            // Create list of Employees
            List<Employee> listEmp = new List<Employee>();

            // Connect to DB
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdListAll  = new SqlCommand(query, conn);
            SqlDataReader reader = cmdListAll.ExecuteReader();

            while(reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.HireDate = Convert.ToDateTime(reader["HireDate"]);
                employee.JobTitle = reader["JobTitle"].ToString();
                employee.RoleID = reader["RoleID"] == DBNull.Value
                                ? (int?)null
                                : Convert.ToInt32(reader["RoleID"]);
                employee.Status = (EmployeeStatus)Enum.Parse(typeof(EmployeeStatus), reader["Status"].ToString());
                listEmp.Add(employee);
            }
            conn.Close();
            return listEmp;
        }

        public static void SaveRecord(Employee employee)
        {
            // Insert Query
            string insertQuery = "INSERT INTO Employees (FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle,RoleID, Status)" +
                                 "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @HireDate, @JobTitle, @RoleID, @Status)";
            // Connect DB 
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;

            cmdInsert.CommandText = insertQuery;
            cmdInsert.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", employee.LastName);
            cmdInsert.Parameters.AddWithValue("@Email", employee.Email);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@HireDate", employee.HireDate);
            cmdInsert.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            cmdInsert.Parameters.AddWithValue("@RoleID", (object)employee.RoleID ?? DBNull.Value);
            cmdInsert.Parameters.AddWithValue("@Status", employee.Status.ToString());
            cmdInsert.ExecuteNonQuery();

            // Close DB
            conn.Close();
        }

        public static Employee SearchRecord (int empID)
        {
            Employee employee = new Employee();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdEmpSearch = new SqlCommand();
            cmdEmpSearch.Connection = conn;
            cmdEmpSearch.CommandText = "SELECT * FROM Employees " +
                                        "WHERE EmployeeID = @EmployeeID";
            cmdEmpSearch.Parameters.AddWithValue("@EmployeeID", empID);
            SqlDataReader reader = cmdEmpSearch.ExecuteReader();
            if (reader.Read())
            {
                employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.HireDate = reader["HireDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["HireDate"]);
                employee.RoleID = reader["RoleID"] == DBNull.Value
                                ? (int?)null
                                : Convert.ToInt32(reader["RoleID"]);
                employee.JobTitle = reader["JobTitle"].ToString();
                employee.Status = Enum.TryParse(reader["Status"].ToString(),true, out EmployeeStatus status)
                                ? status
                                : EmployeeStatus.Inactive;

            }
            else
            {
                employee = null;
            }
            conn.Close();
            return employee;
        }

        public static void DeleteRecord(int employeeID)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                // 1️⃣ Delete the related User first
                SqlCommand cmdUserDelete = new SqlCommand(
                    "DELETE FROM Users WHERE EmployeeID = @EmployeeID", conn);
                cmdUserDelete.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmdUserDelete.ExecuteNonQuery();

                // 2️⃣ Then delete the Employee
                SqlCommand cmdEmpDelete = new SqlCommand(
                    "DELETE FROM Employees WHERE EmployeeID = @EmployeeID", conn);
                cmdEmpDelete.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmdEmpDelete.ExecuteNonQuery();
            }
        }

        public static void UpdateRecord(Employee employeeUpdated)
        {
            string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Email = @Email, " +
                     "PhoneNumber = @PhoneNumber, HireDate = @HireDate, JobTitle = @JobTitle, RoleID = @RoleID, " +
                     "Status = @Status " +
                     "WHERE EmployeeID = @EmployeeID";

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandText = query;
                cmdUpdate.Parameters.AddWithValue("@EmployeeID", employeeUpdated.EmployeeID);
                cmdUpdate.Parameters.AddWithValue("@FirstName", employeeUpdated.FirstName);
                cmdUpdate.Parameters.AddWithValue("@LastName", employeeUpdated.LastName);
                cmdUpdate.Parameters.AddWithValue("@Email", employeeUpdated.Email);
                cmdUpdate.Parameters.AddWithValue("@PhoneNumber", employeeUpdated.PhoneNumber);
                cmdUpdate.Parameters.AddWithValue("@HireDate", employeeUpdated.HireDate);
                cmdUpdate.Parameters.AddWithValue("@JobTitle", employeeUpdated.JobTitle);
                cmdUpdate.Parameters.AddWithValue("@RoleID", (object)employeeUpdated.RoleID ?? DBNull.Value);
                cmdUpdate.Parameters.AddWithValue("@Status", employeeUpdated.Status.ToString());
                cmdUpdate.ExecuteNonQuery();
            }
        }

        public static bool EmployeeExists(int employeeID)
        {
            string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";

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
           

       
    }
}
