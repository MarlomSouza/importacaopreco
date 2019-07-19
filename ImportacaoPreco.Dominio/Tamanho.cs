using System;

namespace ImportacaoPreco.Dominio
{
    public class Tamanho
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