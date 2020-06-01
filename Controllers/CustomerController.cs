using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Domain.Models;
using NorthWind.Domain.Interfaces;

namespace NorthWind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        [Route("GetByCustomerId")]
        public async Task<ActionResult<Customer>> GetByCustomerId(string customerId)
        {
            return await customerService.GetByCustomerId(customerId);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Customer>> GetById(int id)
        {
            return await customerService.GetById(id);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await customerService.GetAll();
        }

        [HttpGet]
        [Route("GetNames")]
        public async Task<IEnumerable<string>> GetCompanyNames()
        {
            return await customerService.GetAllCompanyNames();
        }

    }
}