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
    public class TeamController : ApiController
    {
        private readonly ITeamAppService _teamAppService;

        public TeamController(ITeamAppService teamAppService)
        {
            _teamAppService = teamAppService;
        }


        // GET: api/Team
        public IEnumerable<Team> Get()
        {
            return _teamAppService.GetAll();
        }

        // GET: api/Team/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Team
        public void Post([FromBody]Team team)
        {
            team.Id = Guid.NewGuid();
            team.Ativo = true;
            team.RegisterDateTime = DateTime.Now;
            _teamAppService.Add(team);
        }

        // PUT: api/Team/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Team/5
        public void Delete(int id)
        {
        }
    }
}
