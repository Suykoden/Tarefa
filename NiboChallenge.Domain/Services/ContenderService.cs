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
    public class ContenderService : ServiceBase<Contender>, IContenderService
    {
        private readonly IContenderRepository _contenderRepository;

        public ContenderService(IContenderRepository contenderRepository)
            :base(contenderRepository)
        {
            _contenderRepository = contenderRepository;
        }

       

    }
}
