using JSDeposito.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
