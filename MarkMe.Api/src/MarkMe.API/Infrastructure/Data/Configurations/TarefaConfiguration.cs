using MarkMe.API.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarkMe.API.Infrastructure.Data.Configurations
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(prop => prop.Concluida)
                .IsRequired();
            builder.HasOne(prop => prop.TodoList)
                .WithMany(prop => prop.Tarefas)
                .HasForeignKey(prop => prop.TodoListId)
                .IsRequired();
        }
    }
}
