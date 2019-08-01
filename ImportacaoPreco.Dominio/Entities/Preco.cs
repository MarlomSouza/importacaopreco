using System;
using System.Collections.Generic;
using System.Linq;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Preco : Entity<Preco>
    {
        public decimal ValorBase { get; private set; }
        private IList<PrecoPromocional> precosPromocionais;
        public IEnumerable<PrecoPromocional> PrecosPromocionais => precosPromocionais;
        public decimal Valor()
        {
            if (!precosPromocionais.Any())
                return ValorBase;

            var precoPromocional = precosPromocionais.FirstOrDefault(p => p.EstaVigente);
            return precoPromocional.Valor;
        }

        public Preco(decimal valorBase)
        {
            if (valorBase <= 0)
                throw new ArgumentException("Não deve criar Preço com valor invalido");
            ValorBase = valorBase;
            precosPromocionais = new List<PrecoPromocional>();
        }

        public void AdicionarPrecoPromocional(PrecoPromocional precoPromocional)
        {
            if (precosPromocionais.Any(p => ExistePromocaoNestePeriodo(precoPromocional, p)))
                throw new ApplicationException("Já existe um preço promocional para o periodo desejado");

            precosPromocionais.Add(precoPromocional);
        }

        private static bool ExistePromocaoNestePeriodo(PrecoPromocional precoPromocional, PrecoPromocional precoExistente)
        {
            return precoPromocional.DataInicioPromocao >= precoExistente.DataInicioPromocao && precoPromocional.DataInicioPromocao <= precoExistente.DataFimPromocao ||
                   precoPromocional.DataInicioPromocao >= precoExistente.DataFimPromocao && precoPromocional.DataFimPromocao <= precoExistente.DataFimPromocao;
        }
    }
}