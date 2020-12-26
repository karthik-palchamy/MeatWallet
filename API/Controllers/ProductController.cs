using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Core.Entities;
using Infrastructure.Data;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductController(StoreContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
           var products = await _context.Products.FindAsync(id);//findasync, finds a record with promary key value
            return Ok(products);
        }
    }
}