﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Repositories;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;

namespace NiboChallenger.Application
{
    public class ContenderTeamAppService : AppServiceBase<ContendersTeam>, IContenderTeamAppService
    {
        private readonly IContenderTeamService _contenderTeamService;

        public ContenderTeamAppService(IContenderTeamService contenderTeamService)
        : base(contenderTeamService)
        {
            _contenderTeamService = contenderTeamService;
        }

    }
}
