using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Repositories;

namespace NiboChallenger.Infra.Repositories
{
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {

    }
}
