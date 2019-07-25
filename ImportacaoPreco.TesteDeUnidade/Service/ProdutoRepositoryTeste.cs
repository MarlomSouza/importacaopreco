using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.Predicates;
using ImportacaoPreco.Persistence;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade.Service
{
    public class ProdutoRepositoryTeste
    {
        [Fact]
        public void DeveRetornarListaDeTamanhoDeAcordoComTamanhosDesejados()
        {
            //Given
            var tamanhoGigante = new Tamanho("Gigante") { Id = 1 };
            var tamanhoGrande = new Tamanho("Grande") { Id = 2 };
            var tamanhoPequeno = new Tamanho("Pequeno") { Id = 3 };
            var tamanhosEsperado = new[] { tamanhoGigante, tamanhoGrande, tamanhoPequeno };
            var tamanhosDesejado = new[] { 2 };
            var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: "Encontrar_tamanho").Options;

            using (var context = new AppDbContext(options))
            {
                context.Tamanhos.AddRange(tamanhosEsperado);
                context.SaveChanges();
            }

            //Then
            using (var context = new AppDbContext(options))
            {
                var _repository = new Repository<Tamanho>(context);
                var tamanhos = _repository.ObterTodos(TamanhoPredicate.TamanhoSelecionado(tamanhosDesejado));
                Assert.Collection(tamanhos, p => p = tamanhoGrande);
            }
        }
    }
}