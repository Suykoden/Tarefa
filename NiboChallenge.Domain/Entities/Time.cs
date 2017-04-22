using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Time : EntityWithCodeAndName
    {
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
