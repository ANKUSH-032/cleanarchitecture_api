using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Book.GetBook
{   

    // First Way to declare the MediatR.

    //public class GetBookQuery : IRequest<List<GetBooKVM>>
    //{

    //}

    // Second Way to declare the mediatR.
    // 
    public record GetBookQuery : IRequest<List<GetBooKVM>>;
}
