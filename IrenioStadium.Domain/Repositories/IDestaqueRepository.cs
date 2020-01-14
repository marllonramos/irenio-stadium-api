using System.Collections.Generic;
using IrenioStadium.Domain.Entities;

namespace IrenioStadium.Domain.Repositories
{
    public interface IDestaqueRepository
    {
        void Criar(Destaque destaque);
        void Atualizar(Destaque destaque);
        void Excluir(Destaque destaque);
        IEnumerable<Destaque> Listar(int skip, int take);
    }
}