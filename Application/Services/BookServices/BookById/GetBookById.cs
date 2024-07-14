using Application.Services.Book.GetBook;
using Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.BookServices.BookById
{
    public class GetBookById : IRequest<BookDetails>
    {
        public int BookId { get; set; }
    }
}
