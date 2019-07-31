using System;
using System.Collections.Generic;
using ImportacaoPreco.Dominio.Entities;
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