using System;

namespace ImportacaoPreco.Dominio
{
    public class Preco
    {
        public decimal Valor{get; private set;}
        public Preco(decimal valor)
        {
            if(valor <= 0)
            throw new ArgumentException("Não deve criar Preço com valor invalido");
            Valor = valor;
        }
    }
}