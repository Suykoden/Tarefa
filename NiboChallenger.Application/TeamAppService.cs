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
    public class TeamAppService : AppServiceBase<Team>, ITeamAppService
    {
        private readonly ITeamService _teamService;

        public TeamAppService(ITeamService teamService)
        : base(teamService)
        {
            _teamService = teamService;
        }

    }
}
