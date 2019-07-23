using System;
using System.Collections.Generic;
using ImportacaoPreco.Dominio.Entity;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class GrupoTeste
    {
        [Theory]
        [InlineData("Equipamentos")]
        [InlineData("Calçados")]
        [InlineData("Acessorios")]
        public void DeveCriarGrupoComNome(string nome)
        {
            //Given

            //When
            var grupo = new Grupo(nome);
            //Then
            Assert.Equal(nome, grupo.Nome);

        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void NaoDeveCriarGrupoComNomeInvalido(string nomeinvalido)
        {
            //Given

            //When
            Func<object> testCode = () => new Grupo(nomeinvalido);
            //Then
            var mensagem = Assert.Throws<ArgumentException>(testCode).Message;
            Assert.Equal("Nome do Grupo inválido", mensagem);
        }

        [Fact]
        public void DeveAdicionarSubGruposAoGrupo()
        {
            //Given
            var grupo = new Grupo("Calçados");
            var subgrupo = new Subgrupo("Chuteira", grupo);
            var subgruposEsperados = new List<Subgrupo>() { subgrupo };
            //When
            grupo.AdicionaSubgrupo(subgrupo);
            //Then  
            Assert.Equal(subgruposEsperados, grupo.Subgrupo);
        }

    }
}