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
            builder.OwnsMany(p => p.Tamanhos, t =>
            {
                t.HasForeignKey("ProdutoId");
                t.HasKey("ProdutoId", "Nome");

            });
            builder.OwnsMany(p => p.PrecosPromocionais, pp =>
            {
                pp.Property(x => x.Valor);
                pp.Property(x => x.DataInicioPromocao);
                pp.Property(x => x.DataFimPromocao);
                pp.HasKey("Valor", "DataInicioPromocao", "DataFimPromocao");
            });

            builder.OwnsMany(p => p.Cores, c =>
            {
                c.HasForeignKey("ProdutoId");
                c.HasKey("ProdutoId", "Nome");
            });

            builder.OwnsOne(p => p.Subgrupo, sb =>
            {
                sb.HasForeignKey("ProdutoId");
                sb.HasKey("ProdutoId", "Nome");
                sb.ToTable("Subgrupos");
            });
        }
    }
}