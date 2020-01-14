using System;
using System.Collections.Generic;
using IrenioStadium.Domain.Entities;

namespace IrenioStadium.Domain.Services
{
    public interface IDestaqueApplicationService
    {
        Destaque CriarDestaque(Destaque destaque);
        Destaque AtualizarDestaque(Destaque destaque);
        void ExcluirDestaque(Guid id);
        IEnumerable<Destaque> ListarDestaque(int skip, int take);
    }
}