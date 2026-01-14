using HiTechBooksManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.BLL
{

    public enum EmployeeStatus { Active, Inactive };
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }

        public string JobTitle { get; set; } = string.Empty;

        public int? RoleID { get; set; }

        public EmployeeStatus Status { get;set; }

        public List<Employee> GetAllEmployees() => EmployeeDB.GetAllRecords();

        public void SaveEmployee(Employee employee) => EmployeeDB.SaveRecord(employee);

        public Employee SearchEmployee(int empNB) => EmployeeDB.SearchRecord(empNB);

        public void DeleteEmployee(int empID) => EmployeeDB.DeleteRecord(empID);
        public void UpdateEmployee(Employee employee) => EmployeeDB.UpdateRecord(employee);

    }
}
