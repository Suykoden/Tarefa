using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;

namespace NiboChallenger.Application
{
    public class TournamentFinalAppService : AppServiceBase<TournamentFinal>, ITournamentFinalAppService
    {
        private readonly ITournamentFinalService _tournamentFinalService;

        public TournamentFinalAppService(ITournamentFinalService tournamentFinalService)
        : base(tournamentFinalService)
        {
            _tournamentFinalService = tournamentFinalService;
        }

    }
}
