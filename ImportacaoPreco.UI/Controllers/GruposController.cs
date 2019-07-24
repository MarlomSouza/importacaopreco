using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.UI.Controllers
{
    public class GruposController : BaseController<Grupo, GrupoDto>
    {
        public GruposController(IEntityService<Grupo, GrupoDto> service) : base(service) { }
    }
}