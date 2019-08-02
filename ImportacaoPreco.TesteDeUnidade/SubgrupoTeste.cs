using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.ValueObjects;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class SubgrupoTeste
    {
        Grupo grupoValido = new Grupo("Sapatos");
        const string nomeValido = "Tenis";

        [Fact]
        public void DeveCriarSubGrupo()
        {
            //Given
            const string nome = "Tenis";
            //When
            var subgrupo = new Subgrupo(nome, grupoValido);
            //Then
            Assert.Equal(nome, subgrupo.Nome);
        }


        [Fact]
        public void DeveCriarSubgrupoComGrupo()
        {
            //Given
            var grupo = new Grupo("Roupa");
            //When
            var subgrupo = new Subgrupo(nomeValido, grupo);
            //Then
            Assert.Equal(grupo, subgrupo.Grupo);
        }


        // [Fact]
        // public void NaoDeveCriarSubGrupoComNomeInvalido(string nomeInvalido)
        // {
        //     //Given

        //     //When

        //     //Then
        // }
    }
}