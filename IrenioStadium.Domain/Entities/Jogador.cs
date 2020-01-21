using System;

namespace IrenioStadium.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Gol { get; private set; }
        public int Assistencia { get; private set; }
        public int JogadorDaPartida { get; private set; }
        public int HatTrick { get; private set; }
        public string Foto { get; private set; }

        public Jogador(){}

        public Jogador(string nome, int gol, int assistencia, int jogadorDaPartida, int hatTrick, string foto)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Gol = gol;
            Assistencia = assistencia;
            JogadorDaPartida = jogadorDaPartida;
            HatTrick = hatTrick;
            Foto = foto;
        }

        public Jogador(Guid id, string nome, int gol, int assistencia, int jogadorDaPartida, int hatTrick, string foto)
        {
            Id = id;
            Nome = nome;
            Gol = gol;
            Assistencia = assistencia;
            JogadorDaPartida = jogadorDaPartida;
            HatTrick = hatTrick;
            Foto = foto;
        }
    }
}