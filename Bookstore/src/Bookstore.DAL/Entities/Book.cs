using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DAL.Entities
{
    public class Book
    {
        public Book()
        {

        }

        public Book(int id, string bookName, string auther, string publisher, DateTime releaseDate)
        {
            Id = id;
            BookName = bookName;
            Auther = auther;
            Publisher = publisher;
            ReleaseDate = releaseDate;
        }

        public int Id { get; set; }
        public string BookName { get; set; }
        public string Auther { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
