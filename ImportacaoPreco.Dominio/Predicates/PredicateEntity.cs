using System;
using System.Collections.Generic;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Dominio.Predicates
{
    public static class PredicateEntity
    {
        public static Func<T, bool> Contains<T>(IList<int> ids) where T : Entity<T>
        {
            return (entity => ids.Contains(entity.Id));
        }

    }
}