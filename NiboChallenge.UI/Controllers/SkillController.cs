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
    public class SkillController : ApiController
    {
        private readonly ISkillAppService _skillAppService;

        public SkillController(ISkillAppService skillAppService)
        {
            _skillAppService = skillAppService;
        }
        // GET: api/Habilidade
        public IEnumerable<Skill> Get()
        {
            return _skillAppService.GetAll();
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
