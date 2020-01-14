using System;

namespace IrenioStadium.Domain.Entities
{
    public class Jogo
    {
        public Guid Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Placar { get; private set; }

        public Jogo(){}

        public Jogo(DateTime data, string placar)
        {
            Id = Guid.NewGuid();
            Data = data;
            Placar = placar;
        }
    }
}