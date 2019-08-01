using ImportacaoPreco.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImportacaoPreco.Persistence.Mappings
{
    public class PrecoConfiguration : IEntityTypeConfiguration<Preco>
    {
        public void Configure(EntityTypeBuilder<Preco> builder)
        {
            builder.OwnsMany(p => p.PrecosPromocionais, a => a.HasKey("Valor", "DataInicioPromocao", "DataFimPromocao"));
        }
    }
}