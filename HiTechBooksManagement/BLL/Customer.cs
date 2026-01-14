using HiTechBooksManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HiTechBooksManagement.BLL
{
    public class Customer
    {

        public int CustomerID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public double CreditLimit { get; set; }

        public static DataTable GetAllCustomers() => CustomerDB.GetAllRecords();

        public static void UpdateAllCustomers(DataTable customers) => CustomerDB.UpdateDataTable(customers);

        public static DataRow SearchCustomer(DataTable customers, int cID) => CustomerDB.SearchRecord(customers, cID);

        public static void AddCustomer(DataTable customers, Customer customer) => CustomerDB.AddRecord(customers, customer);

        public static void DeleteCustomer(DataRow datarow) => CustomerDB.DeleteRecord(datarow);
        
        public static decimal GetCustomerCredit(int id, DataTable customers)=> CustomerDB.GetCreditLimitByID(id, customers);






    }
}
