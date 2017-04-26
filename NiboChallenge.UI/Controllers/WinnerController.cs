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
        public IEnumerable<Winner> Get()
        {
            return _winnerAppService.GetAll().Where(w => w.Active == true);
        }

        // POST: api/Winner
        public void Post([FromBody]WinnerDTO winner)
        {
            //Saving de winner from de championship
            Winner win = new Winner
            {
                Id = Guid.NewGuid(),
                DateRegister = DateTime.Now,
                WinnerName = winner.WinnerName,
                Active = true

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


        [HttpPost]
        [Route("home/api/{Winner}/KillTheKing")]
        public void KillTheKing(Winner winner)
        {
            //Sets King off
            var King = _winnerAppService.GetById(winner.Id);
            King.Active = false;
            _winnerAppService.Update(King);
        }

    }
}
