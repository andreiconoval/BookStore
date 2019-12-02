using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data
{
    public class BookRepository : RepositoryBase, IBookRepository
    {
        public BookRepository(DataContext context) : base(context) { }

        public async Task<Book> AddOrUpdate(Book book)
        {
            if (book == null) return null;
            if (book.Id == 0) await _context.Books.AddAsync(book);
            else _context.Books.Update(book);

            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<bool> Exists(string name)
        {
            if (await _context.Books.AnyAsync(b => b.Name == name.ToLower()))
                return true;

            return false;
        }

        public Task<Book> GetBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Book>> GetBooks()
        {
            var books = await _context.Books.ToListAsync();

            return books;
        }

        public Task<bool> Remove(Book book)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Book>> Search(string query)
        {
            throw new System.NotImplementedException();
        }
    }
}