using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Mapeador
{
    public interface IMapper<TEntity, TDto> where TEntity : Entity<TEntity> where TDto : Dto
    {
        TEntity ParaDominio(TDto dto);
        TDto ParaDto(TEntity entity);
    }
}