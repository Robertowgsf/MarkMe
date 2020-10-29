using MarkMe.API.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MarkMe.API.Infrastructure.Data.Contexts
{
    public class MarkMeContext : DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public MarkMeContext(DbContextOptions<MarkMeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
