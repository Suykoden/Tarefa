using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.DTO;
using NiboChallenger.Application.Interface;

namespace NiboChallenger.Application
{
    public class ContenderAppService : AppServiceBase<Contender>, IContenderAppService
    {
        private readonly IContenderService _contenderServiceService;

        public ContenderAppService(IContenderService contenderService)
        : base(contenderService)
        {
            _contenderServiceService = contenderService;
        }

        public IEnumerable<Contender> GetContenders()
        {
            return _contenderServiceService.GetContenders();
        }
    }
}
