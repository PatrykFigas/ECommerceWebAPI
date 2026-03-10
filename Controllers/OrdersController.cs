using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET /api/orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.Products)
                .ToListAsync();

            return Ok(orders);
        }

        // GET /api/orders/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.Products)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        // POST /api/orders
        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(OrderRequest request)
        {
            var products = await _context.Products
                .Where(p => request.ProductIds.Contains(p.Id))
                .ToListAsync();

            var order = new Order
            {
                Products = products
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
        }

        // PUT /api/orders/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, OrderRequest request)
        {
            var order = await _context.Orders
                .Include(o => o.Products)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
                return NotFound();

            var products = await _context.Products
                .Where(p => request.ProductIds.Contains(p.Id))
                .ToListAsync();

            order.Products = products;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE /api/orders/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
                return NotFound();

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}