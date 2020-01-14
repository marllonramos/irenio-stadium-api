using System.Collections.Generic;
using IrenioStadium.Domain.Entities;

namespace IrenioStadium.Domain.Repositories
{
    public interface IJogoRepository
    {
        void Criar(Jogo jogo);
        void Atualizar(Jogo jogo);
        void Excluir(Jogo jogo);
        IEnumerable<Jogo> Listar(int skip, int take);
    }
}