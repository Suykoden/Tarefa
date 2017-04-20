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
    public class JogadorAppService : AppServiceBase<Jogador>, IJogadorAppService
    {
        private readonly IJogadorService _JogadorService;

        public JogadorAppService(IJogadorService jogadorService)
        : base(jogadorService)
        {
            _JogadorService = jogadorService;
        }

    }
}
