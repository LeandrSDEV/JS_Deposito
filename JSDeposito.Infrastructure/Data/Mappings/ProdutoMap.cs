using JSDeposito.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JSDeposito.Infrastructure.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(p => p.Preco)
                   .HasPrecision(10, 2);

            builder.Property(p => p.Ativo)
                   .HasDefaultValue(true);
        }
    }

}
