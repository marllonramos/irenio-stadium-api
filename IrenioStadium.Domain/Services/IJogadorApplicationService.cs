using System;
using System.Collections.Generic;
using IrenioStadium.Domain.Entities;
using IrenioStadium.Domain.ViewModels;

namespace IrenioStadium.Domain.Services
{
    public interface IJogadorApplicationService
    {
        Jogador CriarJogador(CriarJogadorViewModel jogador);
        Jogador AtualizarJogador(AtualizarJogadorViewModel jogador);
        void ExcluirJogador(Guid id);
        IEnumerable<Jogador> ListarJogador();
        Jogador ListarPorId(Guid id);
    }
}