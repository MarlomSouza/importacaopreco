using ImportacaoPreco.Aplicacao;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorController : ControllerBase
    {
        private readonly IEntityService<Cor> _corService;

        public CorController(IEntityService<Cor> corService)
        {
            _corService = corService;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string nome)
        {
            _corService.Criar(nome);
        }

    }
}