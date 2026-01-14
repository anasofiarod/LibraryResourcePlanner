using HiTechBooksManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechBooksManagement.DAL
{
    public class CategoryDB
    {
        public static List<Category> GetAllRecords()
        {
            string query = "SELECT * FROM Categories";

            List<Category> listCategories = new List<Category>();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdListAll = new SqlCommand(query, conn);
            SqlDataReader reader = cmdListAll.ExecuteReader();
            Category category = null;

            while (reader.Read())
            {
                category = MapReaderToCategory(reader);
                listCategories.Add(category);
            }
            conn.Close();
            return listCategories;
        }

        public static Category SearchRecord(int categoryID)
        {
            string query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";
            Category category = null;

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdSearch = new SqlCommand(query, conn))
                {
                    cmdSearch.Parameters.AddWithValue("@CategoryID", categoryID);
                    using (SqlDataReader reader = cmdSearch.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            category = MapReaderToCategory(reader);

                        }
                    }
                }
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving Category with ID {categoryID}.", ex);
            }

        }

        public static List<string> ListAllCategoryNames()
        {
            List<string> categoryNames = new List<string>();

            string query = "SELECT CategoryName FROM Categories ORDER BY CategoryName";

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categoryNames.Add(reader["CategoryName"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return categoryNames;
        }


        public static void SaveRecord(Category category)
        {
            string insertQuery = "INSERT INTO Categories (CategoryName) " + 
                                 "VALUES (@CategoryName)";

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                {
                    AddCategoryParameters(cmdInsert, category);
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error saving category record.", e);
            }
        }

        public static bool UpdateRecord(Category category)
        {
            string updateQuery = "UPDATE Categories SET CategoryName = @CategoryName " +
                                 "WHERE CategoryID = @CategoryID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@CategoryID", category.CategoryID);
                    AddCategoryParameters(cmdUpdate, category);
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error updating Category record.", e);
            }

        }

        public static bool CategoryTitleExists(string categoryTitle)
        {
            string findQuery = "SELECT * FROM Categories " +
                                "WHERE CategoryName = @CategoryName";

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdFind = new SqlCommand(findQuery, conn))
                {
                    cmdFind.Parameters.AddWithValue("@CategoryName", categoryTitle);
                    int rowsAffected = cmdFind.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch 
            {
                throw new Exception("Error finding a Category name");
            }
        }

        public static bool CategoryIDExists(string categoryTitle)
        {
            string findQuery = "SELECT * FROM Categories " +
                                "WHERE CategoryID = @CategoryID";

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdFind = new SqlCommand(findQuery, conn))
                {
                    cmdFind.Parameters.AddWithValue("@CategoryID", categoryTitle);
                    int rowsAffected = cmdFind.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch 
            {
                throw new Exception("Error finding a Category name");
            }
        }




        public static bool DeleteRecord(int categoryID)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                string deleteCategoryQuery = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                using (SqlCommand cmdCategory = new SqlCommand(deleteCategoryQuery, conn))
                {
                    cmdCategory.Parameters.AddWithValue("@CategoryID", categoryID);
                    int rowsAffected = cmdCategory.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static int GetCategoryID(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return 0;
            }
            int categoryID = 0;
            string query = "SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName";
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CategoryName", name);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        categoryID = Convert.ToInt32(reader["CategoryID"]);
                    }
                }
            }

            return categoryID;
        }

        public static string GetCategoryNameByID(int categoryID)
        {
            if (categoryID <= 0)
                return string.Empty;

            string categoryName = string.Empty;
            string query = "SELECT CategoryName FROM Categories WHERE CategoryID = @CategoryID";

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoryName = reader["CategoryName"].ToString();
                        }
                    }
                }
            }
       

            return categoryName;
        }



        private static void AddCategoryParameters(SqlCommand cmd, Category category)
        {
            cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
        }

        private static Category MapReaderToCategory(SqlDataReader reader)
        {
            return new Category
            {
                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                CategoryName = reader["CategoryName"].ToString()
            };

        }
    }
}
