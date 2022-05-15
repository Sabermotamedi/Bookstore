using Bookstore.API.Models;

namespace Bookstore.API.Services
{
    public interface IBookService
    {
        Task<List<BookModels>> ListAsync();
    }
}
