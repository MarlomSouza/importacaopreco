using System;

namespace ImportacaoPreco.Dominio
{
    public class Subgrupo
    {
        public string Nome {get; private set;}
        public Subgrupo(string nome)
        {
            if(string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do Subgrupo invalido");
            Nome = nome;
        }
    }
}