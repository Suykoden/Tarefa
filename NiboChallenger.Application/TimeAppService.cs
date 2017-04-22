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
    public class TimeAppService : AppServiceBase<Time>, ITimeAppService
    {
        private readonly ITimeService _timeService;

        public TimeAppService(ITimeService timeService)
        : base(timeService)
        {
            _timeService = timeService;
        }

    }
}
