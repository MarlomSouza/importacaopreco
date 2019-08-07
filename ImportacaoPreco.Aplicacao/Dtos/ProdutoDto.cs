using System.Collections.Generic;

namespace ImportacaoPreco.Aplicacao.Dtos
{
    public class ProdutoDto : Dto
    {
        public string Subgrupo { get; set; }
        public int GrupoId { get; set; }
        public IList<string> Tamanhos { get; set; }

        public IList<string> Cores { get; set; }

        public decimal Valor_Base { get; set; }

    }
}