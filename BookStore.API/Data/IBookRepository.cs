using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.API.Models;

namespace BookStore.API.Data
{
    public interface IBookRepository
    {
        Task<Book> AddOrUpdate(Book book);
        Task<bool> Remove(Book book);
        Task<IList<Book>> Search(string query);
        Task<bool> Exists(string name);

        Task<Book> GetBook(int id);
        Task<IList<Book>> GetBooks();
    }
}