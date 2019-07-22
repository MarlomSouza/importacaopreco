using System;

namespace ImportacaoPreco.Dominio.VO
{
    public class PrecoPromocional
    {
        public decimal Valor { get; private set; }
        public DateTime DataInicioPromocao { get; private set; }
        public DateTime DataFimPromocao { get; private set; }

        public bool EstaVigente
        {
            get => DateTime.Now >= DataInicioPromocao && DateTime.Now <= DataFimPromocao;
        }

        public PrecoPromocional(decimal valor, DateTime dataInicioPromocao, DateTime dataFimPromocao)
        {
            if (valor <= 0)
                throw new ArgumentException("Não deve criar Preço promocional com valor invalido");

            if (dataFimPromocao < dataInicioPromocao)
                throw new ArgumentException("Não deve criar Preco promocional com Data invalida");

            Valor = valor;
            DataInicioPromocao = dataInicioPromocao;
            DataFimPromocao = dataFimPromocao;
        }
    }
}