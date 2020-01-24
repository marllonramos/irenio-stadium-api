using System;
using System.Collections.Generic;
using IrenioStadium.Domain.Entities;
using IrenioStadium.Domain.Services;
using IrenioStadium.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IrenioStadium.Api.Controllers
{
    [Route("jogador")]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorApplicationService _service;
        public JogadorController(IJogadorApplicationService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("")]
        public Jogador Post([FromBody]CriarJogadorViewModel model)
        {
            var jogador = _service.CriarJogador(model);
            return jogador;
        }

        [HttpPut]
        [Route("")]
        public Jogador Put([FromBody]AtualizarJogadorViewModel model)
        {
            var jogador = _service.AtualizarJogador(model);
            return jogador;
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(Guid id)
        {
            _service.ExcluirJogador(id);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Jogador> Get()
        {
            return _service.ListarJogador();
        }
    }
}