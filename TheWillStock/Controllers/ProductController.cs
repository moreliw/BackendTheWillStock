using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheWillStock.Data;
using TheWillStock.Models;

namespace TheWillStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            return await _context.ProductModel.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ProductModel>> CreateProduct(ProductModel product)
        {
            _context.ProductModel.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(ProductModel), new { id = product.Id }, product);
        }

    }
}
