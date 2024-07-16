using Application.Services.Book.GetBook;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.BookServices.GetBook
{

    // First Way to declare the MediatR.

    public class GetBookQuery : IRequest<List<GetBooKVM>>
    {
        //public int Id { get; set; }
        //public string? Title { get; set; }
        //public string? Author { get; set; }
        //public string? Genre { get; set; }
        //public int PublishedYear { get; set; }
        //public int Quantity { get; set; }
    }

    // Second Way to declare the mediatR.
    // 
    // public record GetBookQuery : IRequest<List<GetBooKVM>>;
}
