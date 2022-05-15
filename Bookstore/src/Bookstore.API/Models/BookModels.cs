namespace Bookstore.API.Models
{
    public class BookModels
    {
        public BookModels(int id, string bookName, string auther, string publisher, DateTime releaseDate)
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
