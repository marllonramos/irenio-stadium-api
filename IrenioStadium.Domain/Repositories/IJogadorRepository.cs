using System.Collections.Generic;
using IrenioStadium.Domain.Entities;

namespace IrenioStadium.Domain.Repositories
{
    public interface IJogadorRepository
    {
        void Criar(Jogador jogador);
        void Atualizar(Jogador jogador);
        void Excluir(Jogador jogador);
        IEnumerable<Jogador> Listar(int skip, int take);
    }
}