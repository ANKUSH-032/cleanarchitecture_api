using AutoMapper;
using Domain.Interface.IBook;
using Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.BookServices.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, int>
    {
        public readonly IBookRepository _bookRepository;
        public readonly IMapper _mapper;
        public UpdateBookCommandHandler(IBookRepository bookRepository, IMapper mapping)
        {
            _bookRepository = bookRepository;
            _mapper = mapping;
        }
        public async Task<int> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var requestData = new BookUpdate()
            {

                Genre = request.Genre,
                Author = request.Author,
                Title = request.Title,
                PublishedYear = request.PublishedYear,
                Quantity = request.Quantity,

            };

            return await _bookRepository.UpdateBookAsync(request.BookID, requestData);
            //return _mapper.Map<int>(book);
        }
    }
}
