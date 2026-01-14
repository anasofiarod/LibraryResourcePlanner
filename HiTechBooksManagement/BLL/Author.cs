using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.DAL
{
    public class Author
    {

        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<Author> GetAllAuthors() => AuthorDB.GetAllRecords();

        public Author SearchAuthor(int authorID) => AuthorDB.SearchRecord(authorID);

        public int SaveAuthor(Author author) => AuthorDB.SaveRecord(author);

        public bool UpdateAuthor(Author author) => AuthorDB.UpdateRecord(author);
        public bool DeleteAuthor(int authorID) => AuthorDB.DeleteRecord(authorID);

        public List<Author> GetAuthorsByBook(int bookID) => AuthorDB.GetRecordsbyAuthor(bookID);




    }
}
