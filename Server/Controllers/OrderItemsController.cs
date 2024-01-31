using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullSD.Server.Data;
using FullSD.Shared.Domain;
using FullSD.Server.IRepository;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FullSD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public OrderItemsController(ApplicationDbContext context)
        public OrderItemsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/OrderItems
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        public async Task<IActionResult> GetOrderItems()
        {

            //return await _context.OrderItems.ToListAsync();
            var orderItems = await _unitOfWork.OrderItems.GetAll(includes: q => q.Include(x => x.Booking).Include(x => x.Food));
            return Ok(orderItems);
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        public async Task<IActionResult> GetOrderItem(int id)
        {
            //var orderItem = await _context.OrderItems.FindAsync(id);
            var orderItem = await _unitOfWork.OrderItems.Get(q=> q.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return Ok(orderItem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderItem)
        {
            if (id != orderItem.Id)
            {
                return BadRequest();
            }

            //_context.Entry(orderItem).State = EntityState.Modified;
            _unitOfWork.OrderItems.Update(orderItem);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!OrderItemExists(id))
                if (!await OrderItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderItem)
        {
            //_context.OrderItems.Add(orderItem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Insert(orderItem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOrderItem", new { id = orderItem.Id }, orderItem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {

            //var orderItem = await _context.OrderItems.FindAsync(id);
            var orderItem = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            //_context.OrderItems.Remove(orderItem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool OrderItemExists(int id)
        private async Task<bool> OrderItemExists(int id)
        {
            //return (_context.OrderItems?.Any(e => e.Id == id)).GetValueOrDefault();
            var orderItem = await _unitOfWork.OrderItems.Get(q=> q.Id == id);
            return orderItem != null;
        }
    }
}
