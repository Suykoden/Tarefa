using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
   public class TournamentFinal: EntityBase
    {

        public string FirstTeamName { get; set; }
        public string SecondTeamName { get; set; }
        public bool Finished { get; set; }
        public Guid TournamentId { get; set; }
        public Tournament Tournament { get; set; }

    }
}
