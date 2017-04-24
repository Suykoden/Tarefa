using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;

namespace NiboChallenger.Application.Interface
{
    public class ContenderCategoryAppService : AppServiceBase<ContenderCategory>, IContenderCategoryAppService
    {
        private readonly IContenderCategoryService _contenderCategoryService;

        public ContenderCategoryAppService(IContenderCategoryService contenderCategoryService)
        : base(contenderCategoryService)
        {
            _contenderCategoryService = contenderCategoryService;
        }

    }
}
