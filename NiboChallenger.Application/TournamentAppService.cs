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

    public class TournamentAppService : AppServiceBase<Tournament>, ITournamentAppService
    {
        private readonly ITournamentService _tournamentService;

        public TournamentAppService(ITournamentService tournamentService)
        : base(tournamentService)
        {
            _tournamentService = tournamentService;
        }

    }
}
