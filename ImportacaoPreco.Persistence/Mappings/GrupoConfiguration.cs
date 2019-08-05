using ImportacaoPreco.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImportacaoPreco.Persistence.Mappings
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.OwnsMany(g => g.Subgrupo, a => a.HasKey(sb => sb.Nome));
        }
    }
}