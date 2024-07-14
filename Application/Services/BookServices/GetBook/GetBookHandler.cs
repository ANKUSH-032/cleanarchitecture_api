using Application.Comman;
using Application.Services.BookServices.GetBook;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Domain.Interface.IBook;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Book.GetBook
{
    public class GetBookHandler : IRequestHandler<GetBookQuery, List<GetBooKVM>>
    {
            public readonly IBookRepository _bookRepository;
            public readonly IMapper _mapper;
        public GetBookHandler(IBookRepository bookRepository, IMapper mapping)
        {
            _bookRepository = bookRepository;
            _mapper = mapping;
        }
        public async Task<List<GetBooKVM>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var bookDetails = await _bookRepository.GetALlBookList();

            // Convert the the book in the List<GetBookvm> using jquery.

            //var book = bookDetails.Select(dto => new GetBooKVM
            //{
            //    Id = dto.Id, // Assuming Book has an Id property
            //    Title = dto.Title,
            //    Author = dto.Author,
            //    PublishedYear = dto.PublishedYear,
            //}).ToList();

            // Comman Method For Mapp the  data .

            var bookList = _mapper.Map<List<GetBooKVM>>(bookDetails);

            return bookList;
        }
    }
}
