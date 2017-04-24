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
    public class ContenderCategoryService : ServiceBase<ContenderCategory>, IContenderCategoryService
    {
        private IContenderCategoryRepository _contenderCategoryRepository;

        public ContenderCategoryService(IContenderCategoryRepository contenderCategoryRepository)
            : base(contenderCategoryRepository)
        {
            _contenderCategoryRepository = contenderCategoryRepository;
        }

    }
}
