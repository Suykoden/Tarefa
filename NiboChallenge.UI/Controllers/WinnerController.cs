using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenger.Application.DTO;
using NiboChallenger.Application.Interface;

namespace NiboChallenge.UI.Controllers
{
    public class WinnerController : ApiController
    {

        private readonly IWinnerAppService _winnerAppService;
        private readonly ITournamentFinalAppService _tournamentFinalAppService;
        private readonly ITournamentAppService _tournamentAppService;

        public WinnerController(IWinnerAppService winnerAppService, ITournamentFinalAppService tournamentFinalAppService, ITournamentAppService tournamentAppService)
        {
            _winnerAppService = winnerAppService;
            _tournamentFinalAppService = tournamentFinalAppService;
            _tournamentAppService = tournamentAppService;
        }
        // GET: api/Winner
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Winner/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Winner
        public void Post([FromBody]WinnerDTO winner)
        {
            //Saving de winner from de championship
            Winner win = new Winner
            {
                Id = Guid.NewGuid(),
                DateRegister = DateTime.Now,
                WinnerName = winner.WinnerName
            };
            _winnerAppService.Add(win);

            //Updating the final status to finished Todo:Isolate routines of insert and update in individual methods
            TournamentFinal final = new TournamentFinal
            {
                Id = winner.TournamentFinalId,
                FirstTeamName = winner.FirstTeamName,
                SecondTeamName = winner.SecondTeamName,
                TournamentId = winner.TournamentId,
                Finished = true
              
            };
            _tournamentFinalAppService.Update(final);

            //Finishing the tournament
            var Tournament = _tournamentAppService.GetById(winner.TournamentId);
            Tournament.Active = false;
            Tournament.Status = "Finalizado";
            _tournamentAppService.Update(Tournament);
        }

        // PUT: api/Winner/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Winner/5
        public void Delete(int id)
        {
        }
    }
}
