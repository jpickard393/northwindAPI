using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Domain.Interfaces
{
    public interface IService<T>
    {
        public Task<T> GetById(int id);
       
    }
}
