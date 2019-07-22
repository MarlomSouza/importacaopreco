using System;

namespace ImportacaoPreco.Dominio.Entity
{
    public class Cor
    {
        public Cor(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da Cor invalida");

            Nome = nome;
        }

        public string Nome { get; set; }
    }
}