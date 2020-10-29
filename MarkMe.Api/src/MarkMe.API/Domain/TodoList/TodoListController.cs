using MarkMe.API.Infrastructure.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MarkMe.API.Domain
{
    [Route("api/[controller]")]
    public class TodoListController : ControllerBase
    {
        private readonly MarkMeContext _context;

        public TodoListController(MarkMeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var todoLists = await _context.TodoLists.ToListAsync();

            return Ok(todoLists);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var todoList = await _context.TodoLists.FindAsync(id);

            return Ok(todoList);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TodoList todoList)
        {
            var entity = todoList;
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return Ok(entity);
        }

    }
}
