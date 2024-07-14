using Application.Services.Book.GetBook;
using Application.Services.BookServices.GetBook;
using AutoMapper;
using Domain.Interface.IBook;
using Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.BookServices.BookById
{
    public class GetBookByIdHandler : IRequestHandler<GetBookById, BookDetails>
    {
        public readonly IBookRepository _bookRepository;
        public readonly IMapper _mapper;

        public GetBookByIdHandler(IBookRepository bookRepository, IMapper mapping)
        {
            _bookRepository = bookRepository;
            _mapper = mapping;
        }
        public async Task<BookDetails> Handle(GetBookById request, CancellationToken cancellationToken)
        {
            var bookDetails = await _bookRepository.GetBookDataById(request.BookId);

            // Comman Method For Mapp the  data .

            var bookList = _mapper.Map<BookDetails>(bookDetails);

            return bookList;
        }
    }
}
