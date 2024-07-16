using Domain.Interface.IBook;
using Domain.Model;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task<List<BookDetails>> GetALlBookList()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<BookDetails> GetBookDataById(int id)
        {
            return await _context!.Books!.FindAsync(id!);
        }

        public async Task<BookInsert> CreateAsync(BookInsert bookInsert)
        {
            var bookDetails = new BookDetails
            {
                Title = bookInsert.Title,
                Author = bookInsert.Author,
                Genre = bookInsert.Genre,
                PublishedYear = bookInsert.PublishedYear,
                Quantity = bookInsert.Quantity
            };

            var entity = _context.Books.Add(bookDetails);
            await _context.SaveChangesAsync();
            return new BookInsert
            {
                Title = entity.Entity.Title,
                Author = entity.Entity.Author,
                Genre = entity.Entity.Genre,
                PublishedYear = entity.Entity.PublishedYear,
                Quantity = entity.Entity.Quantity
            };
        }


        public async Task<int> UpdateBookAsync(int Id, BookUpdate bookUpdate)
        {
            var book = await _context.Books.FindAsync(Id);
            if (book == null)
            {
                return 0;
            }

            _context.Entry(book).CurrentValues.SetValues(bookUpdate);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return 0;
            }

            _context.Books.Remove(book);
            return await _context.SaveChangesAsync();
        }
    }
}
