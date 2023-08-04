using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static testCustomerService.Core;
using static testCustomerService.Entities;

namespace testCustomerService
{
    public class WebApi
    {
        [ApiController]
        [Route("api/[controller]")]
        public class CustomerController : ControllerBase
        {
            private readonly ICustomerService _service;

            public CustomerController(ICustomerService service)
            {
                _service = service;
            }

            [HttpGet]
            public ActionResult<IList<Customer>> Get()
            {
                var customers = _service.GetCustomers();
                return Ok(customers);
            }

            [HttpGet("{id}")]
            public ActionResult<Customer> Get(int id)
            {
                var customer = _service.GetCustomer(id);
                if (customer == null)
                    return NotFound();
                return Ok(customer);
            }

            [HttpPost]
            public ActionResult<Customer> Post([FromBody] Customer customer)
            {
                var addedCustomer = _service.AddCustomer(customer);
                return CreatedAtAction(nameof(Get), new { id = addedCustomer.ID }, addedCustomer);
            }

            [HttpPut("{id}")]
            public ActionResult Put(int id, [FromBody] Customer customer)
            {
                if (id != customer.ID)
                    return BadRequest();

                try
                {
                    _service.UpdateCustomer(customer);
                }
                catch (InvalidOperationException)
                {
                    return NotFound();
                }

                return NoContent();
            }

            [HttpDelete("{id}")]
            public ActionResult Delete(int id)
            {
                try
                {
                    _service.DeleteCustomer(id);
                }
                catch (InvalidOperationException)
                {
                    return NotFound();
                }

                return NoContent();
            }
        }
    }
}
