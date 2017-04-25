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
    public class ContenderTeamService : ServiceBase<ContendersTeam>, IContenderTeamService
    {
        private IContenderTeamRepository _contenderTeamRepository;

        public ContenderTeamService(IContenderTeamRepository contenderTeamRepository)
            : base(contenderTeamRepository)
        {
            _contenderTeamRepository = contenderTeamRepository;
        }

    }
}
