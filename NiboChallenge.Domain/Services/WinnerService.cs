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
   

    public class WinnerService : ServiceBase<Winner>, IWinnnerService
    {
        private IWinnerReposigory _winnerReposigory;

        public WinnerService(IWinnerReposigory winnerReposigory)
            : base(winnerReposigory)
        {
            _winnerReposigory = winnerReposigory;
        }
    }
}
