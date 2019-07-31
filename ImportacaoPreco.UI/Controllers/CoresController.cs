using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.UI.Controllers
{
    public class CoresController : BaseController<Cor, CorDto>
    {
        public CoresController(IEntityService<Cor, CorDto> service) : base(service) { }
    }
}