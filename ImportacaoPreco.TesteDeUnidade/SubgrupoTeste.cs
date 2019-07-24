using System;
using System.Collections.Generic;
using ImportacaoPreco.Dominio;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class SubgrupoTeste
    {

        [Theory]
        [InlineData("Chuteira")]
        public void DeveCriarSubgrupoComNome(string nome)
        {
            //Given

            //When
            var subgrupo = new Subgrupo(nome);
            //Then
            Assert.Equal(nome, subgrupo.Nome);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void NaoDeveCriarSubgrupoComNomeInvalido(string nomeInvalido)
        {
            //Given

            //When
            Action act = () => new Subgrupo(nomeInvalido);
            //Then
            var mensagem = Assert.Throws<ArgumentException>(act).Message;
            Assert.Equal("Nome do Subgrupo invalido", mensagem);
        }

    }
}