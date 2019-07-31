using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    public class SubGruposController : BaseController<Subgrupo, SubgrupoDto>
    {
        public SubGruposController(IEntityService<Subgrupo, SubgrupoDto> service) : base(service) { }
    }
}