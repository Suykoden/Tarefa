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
    public class CompetidorController : ApiController
    {
        private readonly ICompetidorAppService _competidorAppService;

        public CompetidorController(ICompetidorAppService competidorAppService)
        {
            _competidorAppService = competidorAppService;
        }
        // GET: api/Competidor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Competidor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Competidor
        public void Post(Competidor jogador)
        {
            jogador.Id = Guid.NewGuid();
            jogador.Ativo = true;
            jogador.DataCadastro = DateTime.Now;
            _competidorAppService.Add(jogador);
        }

        // PUT: api/Competidor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Competidor/5
        public void Delete(int id)
        {
        }
    }
}
