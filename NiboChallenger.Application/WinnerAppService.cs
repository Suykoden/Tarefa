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
    public class WinnerAppService : AppServiceBase<Winner>, IWinnerAppService
    {
        private readonly IWinnnerService _winnnerService;

        public WinnerAppService(IWinnnerService winnnerService)
        : base(winnnerService)
        {
            _winnnerService = winnnerService;
        }

    }

}
