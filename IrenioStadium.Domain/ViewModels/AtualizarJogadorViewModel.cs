using System;

namespace IrenioStadium.Domain.ViewModels
{
    public class AtualizarJogadorViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Gol { get; set; }
        public int Assistencia { get; set; }
        public int JogadorDaPartida { get; set; }
        public int HatTrick { get; set; }
        public string Foto { get; set; }
        public bool UpdateFoto { get; set; }
    }
}