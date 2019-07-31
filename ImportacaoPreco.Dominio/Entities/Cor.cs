using System;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Cor : Entity<Cor>
    {
        protected Cor() { }

        public Cor(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da Cor invalida");

            Nome = nome;
        }
    }
}