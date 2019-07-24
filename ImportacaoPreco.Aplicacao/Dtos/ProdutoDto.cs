using System.Collections.Generic;

namespace ImportacaoPreco.Aplicacao.Dtos
{
    public class ProdutoDto : Dto
    {
        public int SubgrupoId { get; set; }
        public IList<int> Tamanhos { get; set; }

        public int CorId { get; set; }

        public decimal Valor_Base { get; set; }

    }
}