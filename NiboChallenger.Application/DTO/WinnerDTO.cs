using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiboChallenger.Application.DTO
{
    public class WinnerDTO
    {

        public Guid TournamentFinalId { get; set; }
        public String FirstTeamName { get; set; }
        public String SecondTeamName { get; set; }
        public  Guid TournamentId { get; set; }
        public string WinnerName { get; set; }

    }
}

