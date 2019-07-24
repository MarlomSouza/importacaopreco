using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    public class SubGruposController : BaseController<Subgrupo>
    {
        public SubGruposController(IEntityService<Subgrupo> service) : base(service)
        {
        }


        [HttpPost]
        public void Post([FromBody] SubgrupoDto subgrupo)
        {
            _service.Criar(subgrupo.Nome);
        }
    }
}