using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using Swashbuckle.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using static testCustomerService.Entities;

namespace testCustomerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //public class Customer
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public string Familly { get; set; }
        //    public string FatherName { get; set; }
        //    public int BirthCertificateID { get; set; }
        //    public int NationalID { get; set; }
        //    public string BirthDate { get; set; }
        //    public string Phone { get; set; }
        //    public string Address { get; set; }
        //}

        //public class CustomerContext : DbContext
        //{
        //    public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        //    {
        //    }

        //    public DbSet<Customer> Customers { get; set; }
        //}

        //[Route("api/[controller]")]
        //[ApiController]
        //public class CustomersController : ControllerBase
        //{
        //    private readonly CustomerContext _context;

        //    public CustomersController(CustomerContext context)
        //    {
        //        _context = context;
        //    }

        //    // GET: api/customers
        //    [HttpGet]
        //    public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        //    {
        //        return await _context.Customers.ToListAsync();
        //    }

        //    // GET: api/customers/5
        //    [HttpGet("{id}")]
        //    public async Task<ActionResult<Customer>> GetCustomer(int id)
        //    {
        //        var customer = await _context.Customers.FindAsync(id);

        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }

        //        return customer;
        //    }

        //    // POST: api/customers
        //    [HttpPost]
        //    public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        //    {
        //        _context.Customers.Add(customer);
        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction(nameof(GetCustomer), new { id = customer.ID }, customer);
        //    }

        //    // PUT: api/customers/5
        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> UpdateCustomer(int id, Customer customer)
        //    {
        //        if (id != customer.ID)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(customer).State = EntityState.Modified;
        //        await _context.SaveChangesAsync();

        //        return NoContent();
        //    }

        //    // DELETE: api/customers/5
        //    [HttpDelete("{id}")]
        //    public async Task<IActionResult> DeleteCustomer(int id)
        //    {
        //        var customer = await _context.Customers.FindAsync(id);

        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Customers.Remove(customer);
        //        await _context.SaveChangesAsync();

        //        return NoContent();
        //    }
        //}


    }
}
