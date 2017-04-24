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
    public class HabilidadeService : ServiceBase<Habilidade>, IHabilidadeService
    {
        private IHabilidadeRepository _habilidadeRepository;
        public HabilidadeService(IHabilidadeRepository habilidadeRepository) :
            base(habilidadeRepository)
        {
            _habilidadeRepository = habilidadeRepository;
        }
    }
}
