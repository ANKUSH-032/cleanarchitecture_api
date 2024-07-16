using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.IBook
{
    public interface IBookRepository
    {
        Task<List<BookDetails>> GetALlBookList();
        Task<BookDetails> GetBookDataById(int id);
        Task<BookInsert> CreateAsync(BookInsert bookInsert);
        Task<int> UpdateBookAsync(int Id, BookUpdate bookUpdate);
        Task<int> DeleteAsync(int id);
    }
}
