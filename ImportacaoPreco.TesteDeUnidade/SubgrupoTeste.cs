using System.Collections.Generic;
using ImportacaoPreco.Dominio;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class SubgrupoTeste
    {
        [Fact]
        public void DeveAdicionarSubGruposAoGrupo()
        {
            //Given
            var subgrupo = new Subgrupo("Chuteira");
            var subgruposEsperados = new List<Subgrupo>() { subgrupo };
            var grupo = new Grupo("Calçados");
            //When
            grupo.AdicionaSubgrupo(subgrupo);
            //Then  
            Assert.Equal(subgruposEsperados, grupo.Subgrupo);
        }
    }
}