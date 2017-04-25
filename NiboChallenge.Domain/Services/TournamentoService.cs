using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Repositories;
using NiboChallenge.Domain.Interfaces.Services;

namespace NiboChallenge.Domain.Services
{
    public class TournamenService : ServiceBase<Tournament>, ITournamentService
    {
        private ITournamentRepository _tournamentRepository;

        public TournamenService(ITournamentRepository tournamentRepository)
            : base(tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }
    }
}
