using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using IrenioStadium.Domain.Entities;
using IrenioStadium.Domain.Repositories;
using IrenioStadium.Infra.Persistence.DataContexts;

namespace IrenioStadium.Infra.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly IrenioStadiumDataContext _context;
        public JogadorRepository(IrenioStadiumDataContext context)
        {
            _context = context;
        }
        public void Criar(Jogador jogador)
        {
            _context.Add(jogador);
            _context.SaveChanges();
        }
        public void Atualizar(Jogador jogador)
        {
            _context.Entry<Jogador>(jogador).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Excluir(Guid id)
        {
            var jogador = _context.Jogadores.Find(id);
            
            _context.Remove(jogador);
            _context.SaveChanges();
        }
        public IEnumerable<Jogador> Listar()
        {
            return _context.Jogadores.AsNoTracking().ToList();
        }
    }
}