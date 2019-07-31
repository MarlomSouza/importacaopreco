using ImportacaoPreco.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImportacaoPreco.Persistence.Mappings
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasMany(p => p.Tamanhos);
            builder.HasMany(p => p.Cores);
        }
    }
}