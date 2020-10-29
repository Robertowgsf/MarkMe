using MarkMe.API.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarkMe.API.Infrastructure.Data.Configurations
{
    public class TodoListConfiguration : IEntityTypeConfiguration<TodoList>
    {
        public void Configure(EntityTypeBuilder<TodoList> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
