using System;
using System.Collections.Generic;
using ImportacaoPreco.Dominio;
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
        
    }
}