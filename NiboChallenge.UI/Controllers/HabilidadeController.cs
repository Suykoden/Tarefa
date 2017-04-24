using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;

namespace NiboChallenge.UI.Controllers
{
    public class HabilidadeController : ApiController
    {
        private readonly IHabilidadeAppService _habilidadeAppService;

        public HabilidadeController(IHabilidadeAppService habilidadeAppService)
        {
            _habilidadeAppService = habilidadeAppService;
        }
        // GET: api/Habilidade
        public IEnumerable<Habilidade> Get()
        {
            var teste = _habilidadeAppService.GetAll();
            return _habilidadeAppService.GetAll();
        }

        // GET: api/Habilidade/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Habilidade
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Habilidade/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Habilidade/5
        public void Delete(int id)
        {
        }
    }
}
