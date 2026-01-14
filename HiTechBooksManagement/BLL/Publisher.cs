using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechBooksManagement.DAL;

namespace HiTechBooksManagement.BLL
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public List<Publisher> GetAllPublishers() => PublisherDB.GetAllRecords();
        public Publisher SearchPublisher(int publisherID) => PublisherDB.SearchRecord(publisherID);
        public int SavePublisher(Publisher publisher) => PublisherDB.SaveRecord(publisher);
        public bool UpdatePublisher(Publisher publisher) => PublisherDB.UpdateRecord(publisher);
        public bool DeletePublisher(int publisherID) => PublisherDB.DeleteRecord(publisherID);


    }
}
