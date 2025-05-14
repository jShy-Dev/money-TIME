using Microsoft.AspNetCore.Mvc;
using BudgetApp_MVP.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp_MVP.Controllers
{
    [ApiController]
    [Route("api/budget")]
    public class BudgetController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BudgetController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/budget/categories?userId=1
        [HttpGet("categories")]
        public async Task<IActionResult> GetBudgetCategories(int userId)
        {
            var categories = await _context.BudgetCategories.Where(c => c.UserId == userId).ToListAsync();
            return Ok(categories);
        }

        // POST: api/budget/categories
        [HttpPost("categories")]
        public async Task<IActionResult> CreateBudgetCategory([FromBody] BudgetCategory category)
        {
            _context.BudgetCategories.Add(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }

        // PUT: api/budget/categories/{id}
        [HttpPut("categories/{id}")]
        public async Task<IActionResult> UpdateBudgetCategory(int id, [FromBody] BudgetCategory updatedCategory)
        {
            var category = await _context.BudgetCategories.FindAsync(id);
            if (category == null) return NotFound();

            category.MonthlyLimit = updatedCategory.MonthlyLimit;
            category.YearlyLimit = updatedCategory.YearlyLimit;
            // Update other fields as needed

            await _context.SaveChangesAsync();
            return Ok(category);
        }
    }
}