using System;
using System.Collections.Generic;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Grupo : Entity<Grupo>
    {
        public string Nome { get; private set; }
        public List<Subgrupo> Subgrupo { get; private set; }

        protected Grupo() { }
        
        public Grupo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do Grupo inválido");
            Nome = nome;
            Subgrupo = new List<Subgrupo>();

        }

        public void AdicionaSubgrupo(Subgrupo subgrupo)
        {
            Subgrupo.Add(subgrupo);
        }



    }

}