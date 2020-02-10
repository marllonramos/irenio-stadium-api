using System;
using System.IO;
using System.Text.RegularExpressions;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using IrenioStadium.Domain.Entities;
using IrenioStadium.Domain.ViewModels;

namespace IrenioStadium.Infra.Services
{
    public class FileUpload
    {
        private readonly Account _account;
        private readonly Cloudinary _cloudinary;

        public FileUpload()
        {
            _account = new Account(
                "ha7e8i9t5",
                "429919914782114",
                "HNb860B1R0HlEoY8eVbnDhulv-Q"
            );

            _cloudinary = new Cloudinary(_account);
        }

        public Jogador UploadPhotos(CriarJogadorViewModel model)
        {
            var fileName = Guid.NewGuid().ToString() + ".jpg";
            var data = new Regex(@"data:image\/[a-z]+;base64,").Replace(model.Foto, "");
            byte[] imageBytes = Convert.FromBase64String(data);

            Jogador jogador;

            using (var stream = new MemoryStream(imageBytes))
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(fileName, stream),
                    Transformation = new Transformation().Crop("limit").Width(400).Height(400)
                };

                var uploadResult = _cloudinary.Upload(uploadParams);
                jogador = new Jogador(model.Nome, model.Gol, model.Assistencia, model.JogadorDaPartida, model.HatTrick, uploadResult.Uri.ToString());
            }

            return jogador;
        }

        public Jogador UploadPhotos(AtualizarJogadorViewModel model)
        {
            var fileName = Guid.NewGuid().ToString() + ".jpg";
            var data = new Regex(@"data:image\/[a-z]+;base64,").Replace(model.Foto, "");
            byte[] imageBytes = Convert.FromBase64String(data);

            Jogador jogador;

            using (var stream = new MemoryStream(imageBytes))
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(fileName, stream),
                    Transformation = new Transformation().Crop("limit").Width(400).Height(400)
                };

                var uploadResult = _cloudinary.Upload(uploadParams);
                jogador = new Jogador(model.Id, model.Nome, model.Gol, model.Assistencia, model.JogadorDaPartida, model.HatTrick, uploadResult.Uri.ToString());
            }

            return jogador;
        }
    }
}