using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Golpe : EntityWithCodeAndName
    {
        public int Dano { get; set; }
        public string Detalhe { get; set; }
        public string Efeito { get; set; }
    }
}

