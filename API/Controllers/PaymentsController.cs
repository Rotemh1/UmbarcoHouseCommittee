using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly DataContext _context;

        public PaymentsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> getPayments()
        {
            var payments = await _context.Payments.ToListAsync();

            return payments;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> getPayment(int id){
            return await _context.Payments.FindAsync(id);
        }

    }
}