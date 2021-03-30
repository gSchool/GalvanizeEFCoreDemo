using System;
using System.Collections.Generic;
using GalvanizeCoreDemo.Models;
using GalvanizeCoreDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalvanizeCoreDemo.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _custService;

        public CustomerController(ICustomerService custService) => _custService = custService;

        [HttpGet]
        public IEnumerable<Customer> Get() => _custService.GetCustomers();

        [HttpGet("{id}")]
        public Customer Get(int id) => _custService.GetCustomer(id);

        [HttpPost]
        public void Post([FromBody] Customer newCustomer) => _custService.AddCustomer(newCustomer);

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer updatedCustomer) {
            try
            {
                _custService.UpdateCustomer(id, updatedCustomer);
                return Accepted();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                return base.BadRequest(exception.Message);
            }
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            try
            {
                _custService.DeleteCustomer(id);
                return base.Accepted();
            }
            catch (ArgumentException exception)
            {
                
                return base.BadRequest(exception.Message);
            }
        }
    }
}