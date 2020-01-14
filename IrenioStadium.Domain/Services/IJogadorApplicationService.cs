using System;
using System.Collections.Generic;
using IrenioStadium.Domain.Entities;

namespace IrenioStadium.Domain.Services
{
    public interface IJogadorApplicationService
    {
        Jogador CriarJogador(Jogador jogador);
        Jogador AtualizarJogador(Jogador jogador);
        void ExcluirJogador(Guid id);
        IEnumerable<Jogador> ListarJogador(int skip, int take);
    }
}