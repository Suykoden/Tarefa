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
    public class CompetidorService : ServiceBase<Competidor>, IJogadorService
    {
        private ICompetidorRepository _jogadorRepository;

        public CompetidorService(ICompetidorRepository jogadorRepository)
            :base(jogadorRepository)
        {
            _jogadorRepository = jogadorRepository;
        }

    }
}
