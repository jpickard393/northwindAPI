using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthWind.Domain.Interfaces;
using NorthWind.Domain.Models;

namespace NorthWind.Services
{
    public class CustomerService : ICustomerService
    {
        private NorthWindContext _context;

        public CustomerService(NorthWindContext context)
        {
            this._context = context;
        }

        async Task<Customer> ICustomerService.GetByCustomerId(string customerId)
        {
            var customer =_context.Customers.Where(c => c.CustomerId == customerId).SingleOrDefaultAsync();
            return await customer;
        }

        async Task<Customer> IService<Customer>.GetById(int id)
        {
            var customer = _context.Customers.Where(c => c.Id == id).SingleOrDefaultAsync();
            return await customer;
        }

        async Task<IEnumerable<Customer>> ICustomerService.GetAll()
        {
            var customer = _context.Customers.ToListAsync();
            return await customer;
        }

        async Task<IEnumerable<string>> ICustomerService.GetAllCompanyNames()
        {
            var customer = _context.Customers.Select(n=>n.CompanyName).ToListAsync();
            return await customer;
        }

    }
}
