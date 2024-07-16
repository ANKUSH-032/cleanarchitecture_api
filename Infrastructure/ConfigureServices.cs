using Domain.Interface.IBook;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection serviceDescriptors,
                                                                     IConfiguration configurtion)
        {
            serviceDescriptors.AddDbContext<BookDbContext>(options =>
                                                options.UseSqlServer(configurtion.GetConnectionString("LibraryManagement") ??
                                                throw new InvalidOperationException("connection")
                                                ));
          serviceDescriptors.AddTransient<IBookRepository, BookRepository>();
            return serviceDescriptors;
        }
    }
}
