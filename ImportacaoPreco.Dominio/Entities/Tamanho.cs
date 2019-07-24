using System;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Tamanho : Entity<Tamanho>
    {
        public string Nome { get; }

        protected Tamanho() { }

        public Tamanho(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome do Tamanho invalido");
            }
            Nome = nome;
        }






    }
}