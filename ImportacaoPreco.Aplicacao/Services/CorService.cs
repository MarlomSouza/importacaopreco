using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class CorService : EntityService<Cor, CorDto>, IEntityService<Cor, CorDto>
    {
        public CorService(IRepository<Cor> repository) : base(repository)
        {
        }
    }
}