using HiTechBooksManagement.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechBooksManagement.DAL
{
    public class AuthorDB
    {
        public static List<Author> GetAllRecords()
        {
            string query = "SELECT * FROM Authors";

            List<Author> listAuthors = new List<Author>();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdListAll = new SqlCommand(query, conn);
            SqlDataReader reader = cmdListAll.ExecuteReader();

            while (reader.Read())
            {
                Author author = new Author();
                author.AuthorID = Convert.ToInt32(reader["AuthorID"]);
                author.FirstName = reader["FirstName"].ToString();
                author.LastName = reader["LastName"].ToString();
                author.Email = reader["Email"].ToString();
                author.PhoneNumber = reader["Phone"].ToString();
                listAuthors.Add(author);
            }
            conn.Close();
            return listAuthors;
        }

        public static List<string> ListAllAuthorNames()
        {
            List<string> authorNames = new List<string>();

            string query = "SELECT FirstName + ' '  + LastName as FullName FROM Authors";

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
                                authorNames.Add(reader["FullName"].ToString());
                                
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return authorNames;
        }


        public static Author SearchRecord(int authorID)
        {
            string query = "SELECT * FROM Authors WHERE AuthorID = @AuthorID";
            Author author = null;

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdSearch = new SqlCommand(query, conn))
                {
                    cmdSearch.Parameters.AddWithValue("@AuthorID", authorID);
                    using (SqlDataReader reader = cmdSearch.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            author = MapReaderToAuthor(reader);

                        }
                    }
                }
                return author;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving Author with ID {authorID}.", ex);
            }

        }


        public static int SaveRecord(Author author)
        {

            string insertQuery = @"INSERT INTO Authors (FirstName, LastName, Email, Phone)
                                        VALUES (@FirstName, @LastName, @Email, @Phone);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";  

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                {
                    AddAuthorParameters(cmdInsert, author);

                    int newAuthorID = (int)cmdInsert.ExecuteScalar();
                    return newAuthorID;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error saving Author record.", e);
            }
          
        }

        public static bool UpdateRecord(Author author)
        {
            string updateQuery = "UPDATE Authors SET FirstName = @FirstName, LastName = @LastName, Email = @Email, " +
                                 "Phone = @Phone " +
                                 "WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@AuthorID", author.AuthorID);
                    AddAuthorParameters(cmdUpdate, author);
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error updating Author record.", e);
            }

        }

        public static bool DeleteRecord(int authorID)
        {
            string deleteQuery = "DELETE FROM Authors WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                {
                    cmdDelete.Parameters.AddWithValue("@AuthorID", authorID);
                    int rowsAffected = cmdDelete.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting Author record.", e);
            }
        }

        public static int GetAuthorID(string name)
        {
            
            if (string.IsNullOrWhiteSpace(name))
            {
                return 0;
            }
            int publisherID = 0;
            string query = "SELECT AuthorID FROM Authors WHERE (FirstName + ' ' + LastName) = @FullName";
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", name.Trim());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            publisherID = Convert.ToInt32(reader["AuthorID"]);
                        }
                    }
                }

            }

            return publisherID;
        }

        public static List<Author> GetRecordsbyAuthor(int bookID)
        {
            string query = @"SELECT a.* FROM Authors a
                           INNER JOIN BookAuthors ba ON a.AuthorID = ba.AuthorID
                           WHERE ba.BookID = @BookID
                           ORDER BY a.LastName, a.FirstName";
            List<Author> authors = new List<Author>();

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            authors.Add(new Author
                            {
                                AuthorID = Convert.ToInt32(reader["AuthorID"]),
                                FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                                LastName = reader["LastName"]?.ToString() ?? string.Empty,
                                Email = reader["Email"]?.ToString() ?? string.Empty,
                                PhoneNumber = reader["PhoneNumber"]?.ToString() ?? string.Empty
                            });
                        }
                    }
                }
                return authors;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving authors for book {bookID}.", ex);
            }
        }


        private static void AddAuthorParameters(SqlCommand cmd, Author author)
        {
            cmd.Parameters.AddWithValue("@FirstName", author.FirstName);
            cmd.Parameters.AddWithValue("@LastName", author.LastName);
            cmd.Parameters.AddWithValue("@Email", author.Email);
            cmd.Parameters.AddWithValue("@Phone", author.PhoneNumber);
        }

        private static Author MapReaderToAuthor(SqlDataReader reader)
        {
            return new Author
            {
                AuthorID = Convert.ToInt32(reader["AuthorID"]),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Email = reader["Email"].ToString(),
                PhoneNumber = reader["Phone"].ToString()
            };

        }

    }
}
