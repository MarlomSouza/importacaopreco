using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Dominio.Predicates
{
    public static class TamanhoPredicate
    {
        public static Expression<Func<Tamanho, bool>> TamanhoSelecionado(IList<int> tamanhos)
        {
            foreach (var tamanhoId in tamanhos)
            {
                return (_tamanho => _tamanho.Id == tamanhoId);
            }
            return (true);

        }

    }
}