using System;
using System.Collections.Generic;
using IrenioStadium.Domain.Entities;
using IrenioStadium.Domain.Repositories;
using IrenioStadium.Domain.Services;
using IrenioStadium.Domain.ViewModels;
using IrenioStadium.Infra.Services;

namespace IrenioStadium.ApplicationService.Services
{
    public class JogadorApplicationService : IJogadorApplicationService
    {
        private readonly IJogadorRepository _repository;

        public JogadorApplicationService(IJogadorRepository repository)
        {
            _repository = repository;
        }

        public Jogador CriarJogador(CriarJogadorViewModel model)
        {
            Jogador jogador;

            if (!String.IsNullOrEmpty(model.Foto))
            {
                FileUpload fileUpload = new FileUpload();
                jogador = fileUpload.UploadPhotos(model);
            }
            else
            {
                jogador = new Jogador(model.Nome, model.Gol, model.Assistencia, model.JogadorDaPartida, model.HatTrick, model.Foto);
            }

            _repository.Criar(jogador);

            return jogador;
        }
        public Jogador AtualizarJogador(AtualizarJogadorViewModel model)
        {
            Jogador jogador = _repository.ListarPorId(model.Id);

            if (model.UpdateFoto == true)
            {
                if (!String.IsNullOrEmpty(model.Foto))
                {
                    FileUpload fileUpload = new FileUpload();
                    jogador = fileUpload.UploadPhotos(model);
                }
                else
                {
                    jogador = new Jogador(model.Id, model.Nome, model.Gol, model.Assistencia, model.JogadorDaPartida, model.HatTrick, model.Foto);
                }
            }
            else
            {
                jogador = new Jogador(model.Id, model.Nome, model.Gol, model.Assistencia, model.JogadorDaPartida, model.HatTrick, jogador.Foto);
            }

            _repository.Atualizar(jogador);
            return jogador;
        }
        public void ExcluirJogador(Guid id)
        {
            _repository.Excluir(id);
        }
        public IEnumerable<Jogador> ListarJogador()
        {
            return _repository.Listar();
        }

        public Jogador ListarPorId(Guid id)
        {
            return _repository.ListarPorId(id);
        }
    }
}