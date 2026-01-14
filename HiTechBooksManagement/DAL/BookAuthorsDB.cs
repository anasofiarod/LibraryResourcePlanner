using HiTechBooksManagement.GUI;
using HiTechBooksManagement.VALIDATION;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.DAL
{
    public class BookAuthorsDB
    {
        public static bool AddRecord(int bookID, int authorID)
        {
            if (Validator.BookAuthorExists(bookID, authorID))
            {
                throw new Exception("This author is already associated with this book");
            }

            string query = "INSERT INTO BookAuthors (BookID, AuthorID) VALUES (@BookID, @AuthorID)";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@AuthorID", authorID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding author {authorID} to book {bookID}.", ex);
            }

        }

        public static bool RemoveRecord(int bookID, int authorID)
        {
            string query = "DELETE FROM BookAuthors WHERE BookID = @BookID AND AuthorID = @AuthorID";

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@AuthorID", authorID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error removing author {authorID} from book {bookID}.", ex);
            }
        }

        public static bool RemoveAllRecords(int bookID)
        {
            string query = "DELETE FROM BookAuthors WHERE BookID = @BookID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error removing all authors from book {bookID}.", ex);
            }
        }

        public static bool RemoveAuthors(int authorID)
        {
            string query = "DELETE FROM BookAuthors WHERE AuthorID = @AuthorID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", authorID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Removing author from book {authorID}.", ex);
            }
        }


        public static bool RecordExists(int bookID, int authorID)
        {
            string query = "SELECT COUNT(*) FROM BookAuthors WHERE BookID = @BookID AND AuthorID = @AuthorID";

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@AuthorID", authorID);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public static List<string> GetAuthorsByBookID(int bookID)
        {
            List<String> authorNames = new List<string>();
            string query = @"
                    SELECT a.FirstName + ' ' + a.LastName AS FullName 
                    FROM BookAuthors ba 
                    INNER JOIN Authors a on ba.AuthorID = a.AuthorID
                    WHERE ba.BookID = @BookID
                    ORDER By a.FirstName, a.LastName;";

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
                            authorNames.Add(reader["FullName"].ToString());
                        }
                    }

                }

                return authorNames;
            }
            catch (Exception e)
            {
                throw new Exception("Unable to get authors with Book ID" + bookID);
            }

        }


    }
}
