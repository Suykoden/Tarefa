using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenger.Application.Interface;
using NiboChallenger.Application.DTO;

namespace NiboChallenge.UI.Controllers
{

    public class TournamentController : ApiController
    {
        private readonly ITournamentAppService _tournamentAppService;


        public TournamentController(ITournamentAppService tournamentAppService)
        {
            _tournamentAppService = tournamentAppService;

        }
        // GET: api/Tournament
        public IEnumerable<Tournament> Get()
        {
            return _tournamentAppService.GetAll().Where(t => t.Active == true && t.Status != "Iniciado");
        }

        // GET: api/Tournament/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tournament
        public void Post([FromBody]Tournament tournament)
        {
            tournament.Id = Guid.NewGuid();
            tournament.RegisterDateTime = DateTime.Now;
            tournament.Active = true;
            tournament.Status = "Aguardando inicio";
            _tournamentAppService.Add(tournament);
        }

        // PUT: api/Tournament/5
        public void Put(Tournament tournament)
        {
            tournament.Active = false;
            _tournamentAppService.Update(tournament);
        }
        [HttpPost]
        [Route("home/api/{Tournament}/Update")]
        public void UpdateStatus(Tournament tournament)
        {
            tournament.Status = "Iniciado";
            _tournamentAppService.Update(tournament);
        }

        // DELETE: api/Tournament/5
        public void Delete(int id)
        {
        }
    }
}
