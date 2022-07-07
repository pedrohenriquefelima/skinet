using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Infrastructure.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        //when a request hits the ProductsController, a new instance is created and it will contain all dependencies in it (example: storecontext creates an intance for that specific ProductsController request)
        // ASP core controls lifetime storecotext depending on its configuration
        public ProductsController(StoreContext context){
            _context = context;

        }
        [HttpGet]
        //asyncronous (wait till it is finished)
        //the task will pass the request to a deligaten therefore the thread won't be blocked
        public async Task<ActionResult<List<Product>>> GetProducts() {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) {
            return  await _context.Products.FindAsync(id);
        }
    }
}