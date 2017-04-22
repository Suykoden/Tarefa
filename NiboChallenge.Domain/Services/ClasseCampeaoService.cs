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
    public class ClasseCampeaoService : ServiceBase<ClasseCampeao>, IClasseCampeaoService
    {
        private IClasseCampeaoRepository _classeCampeaoRepository;

        public ClasseCampeaoService(IClasseCampeaoRepository classeCampeaoRepository)
            : base(classeCampeaoRepository)
        {
            _classeCampeaoRepository = classeCampeaoRepository;
        }

    }
}
