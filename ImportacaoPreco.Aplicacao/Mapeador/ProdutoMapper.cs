using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Mapeador
{
    public class ProdutoMapper : IMapper<Produto, ProdutoDto>
    {
        public Produto ParaDominio(ProdutoDto dto)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoDto ParaDto(Produto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}