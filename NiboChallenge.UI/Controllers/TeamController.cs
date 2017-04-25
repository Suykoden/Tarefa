using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using NiboChallenge.Domain.Entities;
using NiboChallenger.Application.DTO;
using NiboChallenger.Application.Interface;

namespace NiboChallenge.UI.Controllers
{
    public class TeamController : ApiController
    {
        private readonly ITeamAppService _teamAppService;
        private readonly IContenderTeamAppService _contenderTeamAppService;

        public TeamController(ITeamAppService teamAppService, IContenderTeamAppService contenderTeamAppService )
        {
            _teamAppService = teamAppService;
            _contenderTeamAppService = contenderTeamAppService;
        }


        // GET: api/Team
        public IEnumerable<Team> Get()
        {
            // returning only the teams that are
            return _teamAppService.GetAll().Where(t => t.Active = true);
        }

        // GET: api/Team/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Team
        [HttpPost]
        public void Post([FromBody]TeamDTO teamDTO)
        {
            //Persisting the team and conterders that belongs to ones team
            Team team = new Team
            {
                Name = teamDTO.Name,
                Id = Guid.NewGuid(),
                RegisterDateTime = DateTime.Now,
                Active = true
            };
            _teamAppService.Add(team);

            //This should be done with a list, sent by the view, but the angularJS was provoking errors, them made this way temporaly
            if (teamDTO.FirstContenderId != Guid.Empty)
            {
                ContendersTeam ct = new ContendersTeam
                {
                    Id = Guid.NewGuid(),
                    ContenderId = teamDTO.FirstContenderId,
                    TeamId = team.Id
                };
                _contenderTeamAppService.Add(ct);
            }
            if (teamDTO.SecondContenderId != Guid.Empty)
            {
                ContendersTeam ct = new ContendersTeam
                {
                    Id = Guid.NewGuid(),
                    ContenderId = teamDTO.SecondContenderId,
                    TeamId = team.Id
                };
                _contenderTeamAppService.Add(ct);
            }

            if (teamDTO.ThirdContenderId != Guid.Empty)
            {
                ContendersTeam ct = new ContendersTeam
                {
                    Id = Guid.NewGuid(),
                    ContenderId = teamDTO.ThirdContenderId,
                    TeamId = team.Id
                };
                _contenderTeamAppService.Add(ct);
            }



        }

        [HttpPut]
        public void Put(Team team)
        {
            // set team false
            team.Active = false;
            _teamAppService.Update(team);
        }

        // DELETE: api/Team/5
        public void Delete(int id)
        {
        }
    }
}
