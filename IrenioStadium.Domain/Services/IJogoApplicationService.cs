using System;
using System.Collections.Generic;
using IrenioStadium.Domain.Entities;

namespace IrenioStadium.Domain.Services
{
    public interface IJogoApplicationService
    {
        Jogo CriarJogo(Jogo jogo);
        Jogo AtualizarJogo(Jogo jogo);
        void ExcluirJogo(Guid id);
        IEnumerable<Jogo> ListarJogo(int skip, int take);
    }
}