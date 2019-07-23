using ImportacaoPreco.Aplicacao;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamanhoController : ControllerBase
    {
        private readonly TamanhoService _tamanhoService;

        public TamanhoController(TamanhoService tamanhoService)
        {
            _tamanhoService = tamanhoService;
        }

           // POST api/values
        [HttpPost]
        public void Post([FromBody] string nome)
        {
            _tamanhoService.Criar(nome);
        }
    }
}