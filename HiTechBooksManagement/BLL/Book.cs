using HiTechBooksManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.BLL
{
    public class Book
    {

        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int YearPublished { get; set; }
        public int QuantityAvailable { get; set; }
        public int? CategoryID { get; set; }
        public int? PublisherID { get; set; }

        public List<Book> GetAllBook() => BookDB.GetAllRecords();

        public List<BookDisplay> GetDisplayBooks() => BookDB.GetDisplayRecords();

        public Book SearchBook(int bookID) => BookDB.SearchRecord(bookID);
        public Book SearchBook(string isbn) => BookDB.SearchRecord(isbn);

        public int SaveBook(Book book) => BookDB.SaveRecord(book);

        public bool UpdateBook(Book book) => BookDB.UpdateRecord(book);
        public bool DeleteBook(int bookID) => BookDB.DeleteRecord(bookID);


    }
}
