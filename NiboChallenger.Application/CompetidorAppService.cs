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
    public class CompetidorAppService : AppServiceBase<Competidor>, ICompetidorAppService
    {
        private readonly ICompetidorService _competidorService;

        public CompetidorAppService(ICompetidorService competidorService)
        : base(competidorService)
        {
            _competidorService = competidorService;
        }

    }
}
