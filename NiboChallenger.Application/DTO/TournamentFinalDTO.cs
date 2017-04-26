using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;

namespace NiboChallenger.Application.DTO
{
    public class TournamentFinalDTO
    {
        public Guid id { get; set; }
        public bool Finished { get; set; }
        public string FirstTeamName { get; set; }
        public string FirstWinner { get; set; }
        public string FourthTeamName { get; set; }
        public string SecondTeamName { get; set; }
        public string SecondWinner { get; set; }
        public string ThirdTeamName { get; set; }
        public Tournament Tournament { get; set; }
        public Guid TournamentId { get; set; }
        public Guid PlayOffId { get; set; }

    }
}