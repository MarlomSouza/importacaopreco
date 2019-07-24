using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class GrupoService : EntityService<Grupo, GrupoDto>, IEntityService<Grupo, GrupoDto>
    {
        public GrupoService(IRepository<Grupo> repository) : base(repository) { }
    }
}