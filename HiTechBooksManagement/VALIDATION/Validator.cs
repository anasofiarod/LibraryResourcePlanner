using HiTechBooksManagement.BLL;
using HiTechBooksManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HiTechBooksManagement.VALIDATION
{
    public class Validator
    {
        public static bool IsValidName(string name)
        {
            if (name.Length == 0) { return false; }
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]) && !Char.IsWhiteSpace(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidID(string id)
        {
            if (!(Regex.IsMatch(id, @"^\d{4}$")))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(phone, @"^(\(\d{3}\)\s?|\d{3}-?)\d{3}-?\d{4}$");
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) { return false; }

            if (!Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", RegexOptions.IgnoreCase))
            {
                return false;
            }
            return true;

        }

        public static bool IsValidPostalCode(string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode)) return false;
            string pattern = @"^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d$"; // Canadian format
            return Regex.IsMatch(postalCode.Trim(), pattern);
        }

        public static bool IsValidDate(string dateText)
        {
            DateTime parsedDate;

            bool isValid = DateTime.TryParse(dateText, out parsedDate);

            return isValid && parsedDate <= DateTime.Today;

        }

        public static bool EmailExists(string email)
        {
            string query = "SELECT * from Employees " +
                            "WHERE Email = @Email";

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdEmailExists = new SqlCommand(query, conn);
            cmdEmailExists.Parameters.AddWithValue("@Email", email);

            SqlDataReader reader = cmdEmailExists.ExecuteReader();

            bool exists = false;
            while (reader.Read())
            {
                exists = true;
                break;
            }
            reader.Close();
            return exists;
        }

        public static bool IsNotEmpty(string input, out string errorMessage, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = $"{fieldName} cannot be empty";
                return false;
            }
            errorMessage = string.Empty;
            return true;

        }

        public static bool IsInt(string input, out int value, out string errorMessage, string fieldName)
        {
            if (!int.TryParse(input, out value))
            {
                errorMessage = $"{fieldName} must be a valid integer.";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }

        public static bool CategoryExists(int categoryID)
        {
            Category category = CategoryDB.SearchRecord(categoryID);
            return category != null;
        }

        public static bool AuthorExists(int authorID)
        {
            Author author = AuthorDB.SearchRecord(authorID);
            return author != null;
        }

        public static bool BookExists(string isbn)
        {
            Book book = BookDB.SearchRecord(isbn);
            return book != null;
        }

        public static bool BookExists(int id)
        {
            Book book = BookDB.SearchRecord(id);
            return book != null;
        }


        public static bool PublisherExists(int publisherID)
        {
            Publisher publisher = PublisherDB.SearchRecord(publisherID);
            return publisher != null;
        }

        public static bool IsValidISBN(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
                return false;

            isbn = isbn.Replace("-", "").Replace(" ", "");

            if (!isbn.StartsWith("9"))
                return false;

            if (isbn.Length != 10 && isbn.Length != 13)
                return false;

            return isbn.All(char.IsDigit);
        }


        public static bool BookAuthorExists(int bookID, int authorID)
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
        public static string CleanISBN(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
                return "";

            return isbn.Replace("-", "").Replace(" ", "").Trim();
        }

        public static string FormatISBN(string isbn)
        {
            isbn = Validator.CleanISBN(isbn);

            if (isbn.Length == 13)
            {
                return $"{isbn.Substring(0, 3)}-{isbn.Substring(3, 1)}-{isbn.Substring(4, 4)}-{isbn.Substring(8, 4)}-{isbn.Substring(12)}";
            }
            else if (isbn.Length == 10)
            {
                return $"{isbn.Substring(0, 1)}-{isbn.Substring(1, 3)}-{isbn.Substring(4, 5)}-{isbn.Substring(9)}";

            }
            return isbn;

        }

        private static void AddBookParameters(SqlCommand cmd, Book book)
        {
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@UnitPrice", book.UnitPrice);
            cmd.Parameters.AddWithValue("@YearPublished", book.YearPublished);
            cmd.Parameters.AddWithValue("@QuantityAvailable", book.QuantityAvailable);
            cmd.Parameters.AddWithValue("@CategoryID", book.CategoryID);
            cmd.Parameters.AddWithValue("@PublisherID", book.PublisherID);
        }


    }
}
