using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenger.SeedWork.DTO;

namespace NiboChallenger.Application.DTO
{
    public class PlayOffDTO : Dto
    {
        public Guid TeamId { get; set; }
        public bool Finished { get; set; }
        public Guid TournamentId { get; set; }
        public Guid FirstTeamId { get; set; }
        public Guid SecondTeamId { get; set; }
        public Guid ThirdTeamId { get; set; }
        public Guid FourthTeamId { get; set; }

    }
}
