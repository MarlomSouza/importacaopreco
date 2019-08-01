using System;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.ValueObjects
{
    public class Tamanho : VO<Tamanho>
    {
        public string Nome { get; protected set; }
        protected Tamanho() { }

        public Tamanho(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome do Tamanho invalido");
            }

            Nome = nome;
        }

        public override bool EqualsCore(Tamanho outro) => Nome == outro.Nome;

    }
}