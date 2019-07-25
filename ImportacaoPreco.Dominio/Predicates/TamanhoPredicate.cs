using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Dominio.Predicates
{
    public static class TamanhoPredicate
    {
        public static Expression<Func<Tamanho, bool>> TamanhoSelecionado(IList<int> tamanhos)
        {
            return (_tamanho => tamanhos.Contains(_tamanho.Id));
        }

    }
}