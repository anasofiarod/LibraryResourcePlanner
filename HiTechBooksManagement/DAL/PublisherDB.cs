using HiTechBooksManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Publisher = HiTechBooksManagement.BLL.Publisher;

namespace HiTechBooksManagement.DAL
{
    public class PublisherDB
    {
        public static List<Publisher> GetAllRecords()
        {
            string query = "SELECT * FROM Publishers";
            Publisher publisher = null;

            List<Publisher> listPublisher = new List<Publisher>();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdListAll = new SqlCommand(query, conn);
            SqlDataReader reader = cmdListAll.ExecuteReader();

            while (reader.Read())
            {
                publisher = MapReaderToPublisher(reader);
                listPublisher.Add(publisher);
            }
            conn.Close();
            return listPublisher;
        }


        public static List<string> ListAllPublisherNames()
        {
            List<string> publisherNames = new List<string>();

            string query = "SELECT PublisherName FROM Publishers ORDER BY PublisherName";

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
                                publisherNames.Add(reader["PublisherName"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return publisherNames;
        }


        public static Publisher SearchRecord(int publisherID)
        {
            string query = "SELECT * FROM Publishers WHERE PublisherID = @PublisherID";
            Publisher publisher = null;

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdSearch = new SqlCommand(query, conn))
                {
                    cmdSearch.Parameters.AddWithValue("@PublisherID", publisherID);
                    using (SqlDataReader reader = cmdSearch.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            publisher = MapReaderToPublisher(reader);
                        }
                    }
                }
                return publisher;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving Publisher with ID {publisher}.", ex);
            }

        }

        public static int SaveRecord(Publisher publisher)
        {
            string insertQuery = "INSERT INTO Publishers (PublisherName, Phone, Email, Address, City, State, PostalCode)" +
                                 "VALUES (@PublisherName, @Phone, @Email, @Address, @City, @State, @PostalCode);" +
                                 "SELECT CAST(SCOPE_IDENTITY() AS INT)";

            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                {
                    AddPublisherParameters(cmdInsert, publisher);
                    int newPublisherID = (int)cmdInsert.ExecuteScalar();
                    return newPublisherID;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error saving Publisher record.", e);
            }
        }

        public static bool UpdateRecord(Publisher publisher)
        {
            string updateQuery = "UPDATE Publishers SET PublisherName = @PublisherName, Phone = @Phone, Email = @email, " +
                                 "Address = @Address, City = @City, " +
                                 "State = @State, PostalCode = @PostalCode" +
                                 "WHERE PublisherID = @PublisherID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@PublisherID", publisher.PublisherID);
                    AddPublisherParameters(cmdUpdate, publisher);
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error updating Publisher record.", e);
            }

        }

        public static bool DeleteRecord(int publisherID)
        {
            string deleteQuery = "DELETE FROM Publishers WHERE PublisherID = @PublisherID";
            try
            {
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                {
                    cmdDelete.Parameters.AddWithValue("@PublisherID", publisherID);
                    int rowsAffected = cmdDelete.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting Publisher record.", e);
            }
        }

        public static int GetPublisherID(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return 0;
            }
            int publisherID = 0;
            string query = "SELECT PublisherID FROM Publishers WHERE PublisherName = @PublisherName";
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PublisherName", name);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            publisherID = Convert.ToInt32(reader["PublisherID"]);
                        }
                    }
                }

            }

            return publisherID;
        }
        public static string GetPublisherNameByID(int publisherID)
        {
            if (publisherID <= 0)
                return string.Empty;

            string publisherName = string.Empty;
            string query = "SELECT PublisherName FROM Publishers WHERE PublisherID = @PublisherID";

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PublisherID", publisherID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        publisherName = reader["PublisherName"].ToString();
                    }
                }
            }

            return publisherName;
        }



        private static void AddPublisherParameters(SqlCommand cmd, Publisher publisher)
        {
            cmd.Parameters.AddWithValue("@PublisherName", publisher.PublisherName);
            cmd.Parameters.AddWithValue("@Phone", publisher.Phone);
            cmd.Parameters.AddWithValue("@Email", publisher.Email);
            cmd.Parameters.AddWithValue("@Address", publisher.Address);
            cmd.Parameters.AddWithValue("@City", publisher.City);
            cmd.Parameters.AddWithValue("@State", publisher.State);
            cmd.Parameters.AddWithValue("@PostalCode", publisher.PostalCode);


        }

        private static Publisher MapReaderToPublisher(SqlDataReader reader)
        {
            return new Publisher
            {
                PublisherID = Convert.ToInt32(reader["PublisherID"]),
                PublisherName = reader["PublisherName"].ToString(),
                Phone = reader["Phone"].ToString(),
                Email = reader["Email"].ToString(),
                Address = reader["Address"].ToString(),
                City = reader["City"].ToString(),
                State = reader["State"].ToString(),
                PostalCode = reader["PostalCode"].ToString(),               
            };

        }
    }
}
