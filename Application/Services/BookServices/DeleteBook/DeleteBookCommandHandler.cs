using AutoMapper;
using Domain.Interface.IBook;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.BookServices.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, int>
    {
        public readonly IBookRepository _bookRepository;
        public readonly IMapper _mapper;
        public DeleteBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            return  await _bookRepository.DeleteAsync(request.Id);
           // return _mapper.Map<int>(deleteBookResponse);
        }
    }
}
