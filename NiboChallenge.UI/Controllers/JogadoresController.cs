using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenger.Application.Interface;

namespace NiboChallenge.UI.Controllers
{
    public class JogadoresController : ApiController
    {
        private readonly IJogadorAppService _jogadorAppService;

        public JogadoresController(IJogadorAppService jogadorAppService)
        {
            _jogadorAppService = jogadorAppService;
        }
        // GET: api/Jogadores
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Jogadores/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Jogadores
        public void Post(Jogador jogador)
        {
            jogador.Id = Guid.NewGuid();
            jogador.Ativo = true;
            jogador.DataCadastro = DateTime.Now;
            _jogadorAppService.Add(jogador);
        }

        // PUT: api/Jogadores/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Jogadores/5
        public void Delete(int id)
        {
        }
    }
}
