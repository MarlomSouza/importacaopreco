using System;
using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class SubgrupoService : EntityService<Subgrupo, SubgrupoDto>, IEntityService<Subgrupo, SubgrupoDto>
    {
        private readonly IRepository<Grupo> _grupoRepository;

        public SubgrupoService(IRepository<Subgrupo> repository, IRepository<Grupo> grupoRepository) : base(repository) => _grupoRepository = grupoRepository;

        public override void Criar(SubgrupoDto entityDto)
        {
            var grupo = _grupoRepository.ObterPorId(entityDto.GrupoId);
            if (grupo == null)
                throw new ArgumentNullException("Grupo não encontrado");

            var subGrupo = new Subgrupo(entityDto.Nome, grupo);
            base.Criar(subGrupo);
        }


    }
}