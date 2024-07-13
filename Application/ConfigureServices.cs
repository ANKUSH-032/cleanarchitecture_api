using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ConfigureServices 
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddAutoMapper(Assembly.GetExecutingAssembly());
            serviceDescriptors.AddMediatR(service =>
            {
                service.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                
            });
            return serviceDescriptors;
        }
    }
}
