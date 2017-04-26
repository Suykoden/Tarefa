using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Repositories;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenge.Domain.Services;

namespace NiboChallenge.Domain.Services
{
    public class TournamentFinalService : ServiceBase<TournamentFinal>, ITournamentFinalService
    {
        private ITournamentFinalRepository _tournamentFinalRepository;

        public TournamentFinalService(ITournamentFinalRepository tournamentFinalRepository)
            : base(tournamentFinalRepository)
        {
            _tournamentFinalRepository = tournamentFinalRepository;
        }
    }
}
