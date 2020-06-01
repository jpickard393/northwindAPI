using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthWind.Domain.Models;

namespace NorthWind.Domain.Interfaces
{
    public interface ICustomerService : IService<Customer>
    {
        public Task<Customer> GetByCustomerId(string customerId);
        public Task<IEnumerable<Customer>> GetAll();
        public Task<IEnumerable<string>> GetAllCompanyNames();

    }
}
