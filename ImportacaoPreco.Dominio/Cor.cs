using System;

namespace ImportacaoPreco.Dominio
{
    public class Cor
    {
        public Cor(string nome)
        {
            if(String.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome da Cor invalida");
            }
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}