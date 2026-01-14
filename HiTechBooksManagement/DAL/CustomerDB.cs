using HiTechBooksManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.DAL
{
    public class CustomerDB
    {
        private static string query = "SELECT CustomerID, Name, Street, City, PostalCode, Phone, Fax, CreditLimit FROM Customers";

        public static DataTable GetAllRecords()
        {
            DataTable dtCustomers = new DataTable("Customers");

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.Fill(dtCustomers);

                if (dtCustomers.Columns.Contains("CustomerID"))
                {
                    dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerID"] };

                    DataColumn idColumn = dtCustomers.Columns["CustomerID"];
                    idColumn.AutoIncrement = true;
                    idColumn.AutoIncrementSeed = 1; 
                    idColumn.AutoIncrementStep = 1;
                }
                else
                    throw new Exception("CustomerID column not found!");
            }
            return dtCustomers;

        }

        public static DataTable GetCustomersNames()
        {
            DataTable dtCustomers = new DataTable("Customers");

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT CustomerID, Name FROM Customers ORDER BY Name", conn))
            {
                adapter.Fill(dtCustomers);
            }

            return dtCustomers;
        }

        public string GetCustomerNamebyID(int id, DataTable dtCustomers)
        {
           DataRow customerRow = CustomerDB.SearchRecord(dtCustomers, id);
           return customerRow?["Name"].ToString().Trim() ?? string.Empty;
        }


        public static void UpdateDataTable(DataTable dtCustomers)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                if (dtCustomers.PrimaryKey.Length == 0 && dtCustomers.Columns.Contains("CustomerID"))
                    dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerID"] };

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dtCustomers);
            }
        }

        public static DataRow SearchRecord(DataTable dtCustomers, int custId)
        {
            DataRow[] rows = dtCustomers.Select("CustomerID = " + custId);
            return rows.Length > 0 ? rows[0] : null;
        }

        public static void AddRecord(DataTable dtCustomers, Customer customer)
        {
            DataRow newRow = dtCustomers.NewRow();
            newRow["Name"] = customer.Name;
            newRow["Street"] = customer.Street;
            newRow["City"] = customer.City;
            newRow["PostalCode"] = customer.PostalCode;
            newRow["Phone"] = customer.Phone;
            newRow["Fax"] = customer.Fax;
            newRow["CreditLimit"] = customer.CreditLimit;

            dtCustomers.Rows.Add(newRow);
        }

        public static void DeleteRecord(DataRow row)
        {
            row.Delete();
        }

        public static decimal GetCreditLimitByID(int id, DataTable dtCustomers)
        {
            DataRow row = SearchRecord(dtCustomers, id);

            if (row != null && row["CreditLimit"] != DBNull.Value)
                return Convert.ToDecimal(row["CreditLimit"]);

            return 0;
        }
    }

   }
