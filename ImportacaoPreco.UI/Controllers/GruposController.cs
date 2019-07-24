using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    public class GruposController : BaseController<Grupo>
    {
        public GruposController(IEntityService<Grupo> service) : base(service)
        {
        }

        [HttpPost]
        public void Post([FromBody] GrupoDto grupo)
        {
            _service.Criar(grupo.Nome);
        }
    }
}