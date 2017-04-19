using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Jogador : EntityWithCodeAndName
    {
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public bool Ativo { get; set; }
    }
}
