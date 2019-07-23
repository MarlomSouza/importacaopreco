using System;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Tamanho : Entity
    {
        public string Nome { get; }
        public Tamanho(string nome)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome do Tamanho invalido");
            }
            Nome = nome;
        }

       

       


    }
}