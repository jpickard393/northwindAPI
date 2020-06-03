using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthWind.Domain.Interfaces;
using NorthWind.Domain.Models;

namespace NorthWind.Services
{
    public class ProductService : IProductService
    {
        Task<Product> IService<Product>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
