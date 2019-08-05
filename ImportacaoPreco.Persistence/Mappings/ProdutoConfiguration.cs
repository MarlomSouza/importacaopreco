using ImportacaoPreco.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImportacaoPreco.Persistence.Mappings
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.OwnsMany(p => p.Tamanhos, t => t.HasKey(x => x.Nome));
            builder.OwnsMany(p => p.PrecosPromocionais, t => t.Property(pp => pp.Valor).HasColumnName("Valor"));
            builder.OwnsMany(p => p.Cores, c => c.HasKey(x => x.Nome));
            builder.OwnsOne(p => p.Subgrupo, sb => sb.ToTable("Subgrupo"));

        }
    }
}