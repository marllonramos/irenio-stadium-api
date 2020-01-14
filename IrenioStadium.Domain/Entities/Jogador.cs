using System;

namespace IrenioStadium.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Gol { get; private set; }
        public int Assistencia { get; private set; }
        public string Foto { get; set; }

        public Jogador(){}

        public Jogador(string nome, int gol, int assistencia, string foto)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Gol = gol;
            Assistencia = assistencia;
            Foto = foto;
        }
    }
}