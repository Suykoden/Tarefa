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
    public class PlayOffService : ServiceBase<Playoffs>, IPlayOffService
    {
        private IPlayOffRepository _playoffRepository;

        public PlayOffService(IPlayOffRepository playoffRepository)
            : base(playoffRepository)
        {
            _playoffRepository = playoffRepository;
        }

    }
}
