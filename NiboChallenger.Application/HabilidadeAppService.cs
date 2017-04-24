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
    public class HabilidadeAppService : AppServiceBase<Habilidade>, IHabilidadeAppService
    {
        private readonly IHabilidadeService _habilidadeService;

        public HabilidadeAppService(IHabilidadeService habilidadeService) :
            base(habilidadeService)
        {
            _habilidadeService = habilidadeService;
        }
    }
}
