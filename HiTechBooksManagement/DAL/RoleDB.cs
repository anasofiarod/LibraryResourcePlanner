using HiTechBooksManagement.BLL;
using HiTechBooksManagement.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.DAL
{
    public static class RoleDB
    {

        public static bool RoleExists(int roleID)
        {
            string query = "SELECT COUNT(*) FROM Roles WHERE RoleID = @RoleID";

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            using (SqlCommand cmdRoleExists = new SqlCommand(query, conn))
            {
                cmdRoleExists.Parameters.AddWithValue("@RoleID", roleID);
                int count = (int)cmdRoleExists.ExecuteScalar();
                return count > 0;
            }
        }

 }

        
    }

