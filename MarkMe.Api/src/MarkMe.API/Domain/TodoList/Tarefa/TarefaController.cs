using MarkMe.API.Infrastructure.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MarkMe.API.Domain
{
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly MarkMeContext _context;

        public TarefaController(MarkMeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Tarefa tarefa)
        {
            var todoList = await _context.TodoLists.FindAsync(tarefa.TodoListId);

            if (todoList == null) return BadRequest();

            todoList.CriarTarefa(tarefa);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> GetBySelector([FromBody] TarefaSelector selector)
        {
            var query = _context.Tarefas.AsNoTracking();

            if (selector.TodoListId.HasValue)
            {
                query.Where(a => a.TodoListId == selector.TodoListId);
            }

            query.Skip(selector.Page * selector.Amount).Take(selector.Amount);

            var result = await query.ToListAsync();

            return Ok(result);
        }

    }
}
