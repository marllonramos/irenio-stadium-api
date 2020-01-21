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
        public Jogador Post([FromBody]CriarJogadorViewModel model)
        {
            var branch = _service.CriarJogador(model);
            return branch;
        }

        [HttpPut]
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
        public IEnumerable<Jogador> Get()
        {
            return _service.ListarJogador();
        }
    }
}