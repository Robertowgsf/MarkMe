using MarkMe.API.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarkMe.API.Infrastructure.Data.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();
            builder.Property(prop => prop.Cor)
                .HasColumnType("varchar(50)")
                .IsRequired();
            builder.HasOne(prop => prop.Tarefa)
                .WithMany(prop => prop.Categorias)
                .HasForeignKey(prop => prop.TarefaId)
                .IsRequired();
        }
    }
}
