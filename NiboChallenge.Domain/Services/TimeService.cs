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
    public class TimeService: ServiceBase<Time>, ITimeService
    {
        private ITimeRepository _timeRepository;

        public TimeService(ITimeRepository timeRepository)
            :base(timeRepository)
        {
            _timeRepository = timeRepository;
        }
    }
}
