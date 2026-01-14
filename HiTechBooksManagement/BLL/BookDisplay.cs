using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechBooksManagement.DAL;

namespace HiTechBooksManagement.BLL
{
    public class BookDisplay
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int YearPublished { get; set; }
        public int QuantityAvailable { get; set; }
        public string Category { get; set; }  
        public string Publisher { get; set; } 

        public List<Author> Authors { get; set; }
    }
}
