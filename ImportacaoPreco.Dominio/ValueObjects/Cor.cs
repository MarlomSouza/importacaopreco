using System;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.ValueObjects
{
    public class Cor : VO<Cor>
    {
        public string Nome { get; private set; }
        protected Cor() { }

        public Cor(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da Cor invalida");

            Nome = nome;
        }

        public override bool EqualsCore(Cor outro) => Nome == outro.Nome;
    }
}