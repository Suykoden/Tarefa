using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;
using NiboChallenger.Application.DTO;

namespace NiboChallenge.UI.Controllers
{
    public class PlayOffController : ApiController
    {
        private readonly IPlayoffAppService _playofffAppService;


        public PlayOffController(IPlayoffAppService playofffAppService)
        {
            _playofffAppService = playofffAppService;
        }

        // GET: api/PlayOff
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PlayOff/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PlayOff
        public void Post(PlayOffDTO playoff)
        {
            //Todo: Refactoring, this isn't the rigth way make this, oath to be a list or something 

            if (playoff.FirstTeamId != Guid.Empty)
            {
                Playoffs play = new Playoffs();
                play.Id = Guid.NewGuid();
                play.TournamentId = playoff.Id;
                play.TeamId = playoff.FirstTeamId;
                _playofffAppService.Add(play);
            }

            if (playoff.SecondTeamId != Guid.Empty)
            {
                Playoffs play = new Playoffs();
                play.Id = Guid.NewGuid();
                play.TournamentId = playoff.Id;
                play.TeamId = playoff.SecondTeamId;
                _playofffAppService.Add(play);
            }

            if (playoff.ThirdTeamId != Guid.Empty)
            {
                Playoffs play = new Playoffs();
                play.Id = Guid.NewGuid();
                play.TournamentId = playoff.Id;
                play.TeamId = playoff.ThirdTeamId;
                _playofffAppService.Add(play);
            }

            if (playoff.FourthTeamId != Guid.Empty)
            {
                Playoffs play = new Playoffs();
                play.Id = Guid.NewGuid();
                play.TournamentId = playoff.Id;
                play.TeamId = playoff.FourthTeamId;
                _playofffAppService.Add(play);
            }

        }

        // PUT: api/PlayOff/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PlayOff/5
        public void Delete(int id)
        {
        }
    }
}
