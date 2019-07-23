using System.Collections.Generic;

namespace ImportacaoPreco.Dominio.Entity
{
    public class Subgrupo
    {
        public readonly string Nome;
        public readonly Grupo Grupo;
        public Subgrupo(string nome, Grupo grupo)
        {
            Nome = nome;
            Grupo = grupo;

        }

    }
}