using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechBooksManagement.DAL;
namespace HiTechBooksManagement.BLL
{
    public class BookAuthors
    {
        public int BookAuthorID { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public bool AddBookAuthor(int bookID, int authorID) =>BookAuthorsDB.AddRecord(bookID, authorID);
        public bool RemoveBookAuthors(int bookID, int authorID) =>BookAuthorsDB.RemoveRecord(bookID, authorID);

        public bool RemoveAllAuthorsFromBook(int bookID) => BookAuthorsDB.RemoveAllRecords(bookID);


        public bool BookAuthorExists(int bookID, int authorID) => BookAuthorsDB.RecordExists(bookID, authorID);



    }
}
