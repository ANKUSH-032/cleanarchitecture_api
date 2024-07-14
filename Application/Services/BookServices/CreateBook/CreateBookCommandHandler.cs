using AutoMapper;
using Domain.Interface.IBook;
using Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.BookServices.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, BookInsert>
    {
        public readonly IBookRepository _bookRepository;
        public readonly IMapper _mapper;
        public CreateBookCommandHandler(IBookRepository bookRepository, IMapper mapping)
        {
            _bookRepository = bookRepository;
            _mapper = mapping;
        }
        public async Task<BookInsert> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var requestData = new BookInsert()
            {
                Genre = request.Genre,
                Author = request.Author,
                Title = request.Title,
                PublishedYear = request.PublishedYear,
                Quantity = request.Quantity,

            };
            var book = await _bookRepository.CreateAsync(requestData);

            return _mapper.Map<BookInsert>(book);
        }
    }
}
