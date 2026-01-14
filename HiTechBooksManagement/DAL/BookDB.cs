using HiTechBooksManagement.BLL;
using HiTechBooksManagement.VALIDATION;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HiTechBooksManagement.GUI.FormBookManagementMain;

namespace HiTechBooksManagement.DAL
{
    public class BookDB
    {
        public static List<Book> GetAllRecords()
        {
            string query = "SELECT * FROM Books";

            List<Book> listBook = new List<Book>();

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdListAll = new SqlCommand(query, conn);
            SqlDataReader reader = cmdListAll.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book();
                book.BookID = Convert.ToInt32(reader["BookID"]);
                book.ISBN = reader["ISBN"].ToString();
                book.Title = reader["Title"].ToString();
                book.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                book.YearPublished = Convert.ToInt32(reader["YearPublished"]);
                book.QuantityAvailable = Convert.ToInt32(reader["QuantityAvailable"]);
                book.CategoryID = !Convert.IsDBNull(reader["CategoryID"])
                                ? Convert.ToInt32(reader["CategoryID"])
                                : 0;
                book.PublisherID = !Convert.IsDBNull(reader["PublisherID"])
                            ? Convert.ToInt32(reader["PublisherID"])
                            : 0; listBook.Add(book);
            }
            conn.Close();
            return listBook;
        }
        public static List<BookDisplay> GetDisplayRecords()
        {
            string query = @"SELECT b.BookID, b.ISBN, b.Title, b.UnitPrice, b.YearPublished, 
                    b.QuantityAvailable, 
                    COALESCE(c.CategoryName, 'Uncategorized') AS Category, 
                    COALESCE(p.PublisherName, 'Publisher Unknown') AS Publisher
             FROM Books b
             LEFT JOIN Categories c ON b.CategoryID = c.CategoryID
             LEFT JOIN Publishers p ON b.PublisherID = p.PublisherID";

            List<BookDisplay> displayBooks = new List<BookDisplay>();

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    BookDisplay display = new BookDisplay
                    {
                        BookID = Convert.ToInt32(reader["BookID"]),
                        ISBN = reader["ISBN"].ToString(),
                        Title = reader["Title"].ToString(),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        YearPublished = Convert.ToInt32(reader["YearPublished"]),
                        QuantityAvailable = Convert.ToInt32(reader["QuantityAvailable"]),
                        Category = reader["Category"].ToString(),
                        Publisher = reader["Publisher"].ToString()
                    };
                    displayBooks.Add(display);
                }
            }
            return displayBooks;
        }

        public static Book SearchRecord(int bookID)
        {
            string query = "SELECT * FROM Books WHERE BookID = @BookID";
            Book book = null;

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdSearch = new SqlCommand(query, conn))
                {
                    cmdSearch.Parameters.AddWithValue("@BookID", bookID);
                    using (SqlDataReader reader = cmdSearch.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = MapReaderToBook(reader);
                        }
                    }
                }
                return book;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving Book with ID {bookID}.", ex);
            }

        }



        public static Book SearchRecord(string isbn)
        {
            string query = "SELECT * FROM Books WHERE ISBN = @ISBN";
            Book book = null;

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdSearch = new SqlCommand(query, conn))
                {
                    cmdSearch.Parameters.AddWithValue("@ISBN", isbn);
                    using (SqlDataReader reader = cmdSearch.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = MapReaderToBook(reader);
                        }
                    }
                }
                return book;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving Book with ISBN {isbn}.", ex);
            }

        }

        public static int SaveRecord(Book book)
        {

            string insertQuery = @"INSERT INTO Books (ISBN, Title, UnitPrice, YearPublished, QuantityAvailable, CategoryID, PublisherID)
                                        VALUES (@ISBN, @Title, @UnitPrice, @YearPublished, @QuantityAvailable, @CategoryID, @PublisherID);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                {
                    AddBookParameters(cmdInsert, book);
                    int newBookID = (int)cmdInsert.ExecuteScalar();
                    return newBookID;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error saving Book record.", e);
            }
        }

        public static bool UpdateRecord(Book book)
        {
            string updateQuery = "UPDATE Books SET ISBN = @ISBN, Title = @Title, UnitPrice = @UnitPrice, " +
                                 "YearPublished = @YearPublished, QuantityAvailable = @QuantityAvailable, " +
                                 "CategoryID = @CategoryID, PublisherID = @PublisherID " +
                                 "WHERE BookID = @BookID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@BookID", book.BookID);
                    AddBookParameters(cmdUpdate, book);
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error updating Book record.", e);
            }

        }

        public static bool DeleteRecord(int bookID)
        {
            string deleteQuery = "DELETE FROM Books WHERE BookID = @BookID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                {
                    cmdDelete.Parameters.AddWithValue("@BookID", bookID);
                    int rowsAffected = cmdDelete.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting Book record.", e);
            }
        }



        private static Book MapReaderToBook(SqlDataReader reader)
        {
            return new Book
            {
                BookID = Convert.ToInt32(reader["BookID"]),
                ISBN = reader["ISBN"].ToString(),
                Title = reader["Title"].ToString(),
                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                YearPublished = Convert.ToInt32(reader["YearPublished"]),
                QuantityAvailable = Convert.ToInt32(reader["QuantityAvailable"]),
                CategoryID = reader["CategoryID"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["CategoryID"]),
                PublisherID = reader["PublisherID"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["PublisherID"])
            };

        }
        private static void AddBookParameters(SqlCommand cmd, Book book)
        {

            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@UnitPrice", book.UnitPrice);
            cmd.Parameters.AddWithValue("@YearPublished", book.YearPublished);
            cmd.Parameters.AddWithValue("@QuantityAvailable", book.QuantityAvailable);
            if (book.CategoryID == null)
                cmd.Parameters.AddWithValue("@CategoryID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@CategoryID", book.CategoryID);

            if (book.PublisherID == null)
                cmd.Parameters.AddWithValue("@PublisherID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@PublisherID", book.PublisherID);


        }
    }
}
