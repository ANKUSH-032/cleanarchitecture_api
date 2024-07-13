using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comman
{
    public interface IMappingFrom<T> //where T : class
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType()); 
    }
}
