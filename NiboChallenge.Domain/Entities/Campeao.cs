using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Campeao : EntityWithCodeAndName
    {
        public Guid TipoId { get; set; }
        public ClasseCampeao Tipo { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public bool Ativo { get; set; }

    }
}

