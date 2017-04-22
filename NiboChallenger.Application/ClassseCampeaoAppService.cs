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
    public class ClasseCampeaoAppService : AppServiceBase<ClasseCampeao>, IClasseCampeaoAppService
    {
        private readonly IClasseCampeaoService _classeCampeaoService;

        public ClasseCampeaoAppService(IClasseCampeaoService classeCampeaoService)
        : base(classeCampeaoService)
        {
            _classeCampeaoService = classeCampeaoService;
        }

    }
}
