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
    public class TournamentFinalController : ApiController
    {
        private readonly ITournamentFinalAppService _tournamentFinalAppService;
        private readonly IPlayoffAppService _playoffAppService;


        public TournamentFinalController(ITournamentFinalAppService tournamentFinalAppService, IPlayoffAppService playoffAppService)
        {
            _tournamentFinalAppService = tournamentFinalAppService;
            _playoffAppService = playoffAppService;
        }
        // GET: api/TournamentFinal
        public IEnumerable<TournamentFinal> Get()
        {
            return _tournamentFinalAppService.GetAll().Where(t => t.Finished == false);
        }

        // POST: api/TournamentFinal
        [HttpPost]
        public void PostTournament(TournamentFinalDTO tournamentFinal)
        {
            //Save de finalist
            TournamentFinal final = new TournamentFinal
            {
                Id = Guid.NewGuid(),
                TournamentId = tournamentFinal.TournamentId,
                Finished = false,
                FirstTeamName = tournamentFinal.FirstWinner,
                SecondTeamName = tournamentFinal.SecondWinner
            };
            _tournamentFinalAppService.Add(final);

            Playoffs play = new Playoffs
            {
                Id = tournamentFinal.PlayOffId,
                FirstTeamName = tournamentFinal.FirstTeamName,
                SecondTeamName = tournamentFinal.SecondTeamName,
                ThirdTeamName = tournamentFinal.ThirdTeamName,
                FourthTeamName = tournamentFinal.FourthTeamName,
                TournamentId = tournamentFinal.TournamentId,
                Finished = true
            };

            //Update de status of playoffs to finished
            _playoffAppService.Update(play);
        }
    }
}
