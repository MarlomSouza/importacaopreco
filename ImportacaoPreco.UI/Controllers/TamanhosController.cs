using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.UI.Controllers
{
    public class TamanhosController : BaseController<Tamanho, TamanhoDto>
    {
        public TamanhosController(IEntityService<Tamanho, TamanhoDto> service) : base(service) { }
    }
}