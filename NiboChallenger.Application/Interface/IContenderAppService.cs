using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;

namespace NiboChallenger.Application.Interface
{
    public interface IContenderAppService : IAppServiceBase<Contender>
    {
        IEnumerable<Contender>GetContenders();
    }
}
