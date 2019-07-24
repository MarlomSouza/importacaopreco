using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class TamanhoService : EntityService<Tamanho, TamanhoDto>, IEntityService<Tamanho, TamanhoDto>
    {
        public TamanhoService(IRepository<Tamanho> repository) : base(repository) { }

    }
}