using Application.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using System.Threading.Tasks;

namespace Application.Services.Book.GetBook
{
    public class GetBooKVM : IMappingFrom<BookDetails>
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int PublishedYear { get; set; }
        public int Quantity { get; set; }
    }
}
