using System;

namespace IrenioStadium.Domain.Entities
{
    public class Destaque
    {
        public Guid Id { get; private set; }
        public Jogador Jogador { get; private set; }
        public Jogo Jogo { get; private set; }

        public Destaque(){}

        public Destaque(Jogador jogador, Jogo jogo)
        {
            Id = Guid.NewGuid();
            Jogador = jogador;
            Jogo = jogo;
        }
    }
}