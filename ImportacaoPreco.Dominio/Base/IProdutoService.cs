using System.Collections.Generic;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.Base
{
    public interface IProdutoService
    {
        void CriarProduto(string nome, IEnumerable<Tamanho> tamanhos, IEnumerable<Cor> cores, IEnumerable<Subgrupo> subgrupos, Preco preco);
    }
}