using Bookstore.API.Models;
using Bookstore.DAL;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.API.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _dbContext;

        public BookService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BookModels>> ListAsync()
        {
            var book = await _dbContext.Books.Select(x => new BookModels(x.Id, x.BookName, x.Auther, x.Publisher, x.ReleaseDate)).ToListAsync();
            return book;
        }
    }
}
