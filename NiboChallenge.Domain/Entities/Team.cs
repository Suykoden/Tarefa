using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Team : EntityWithCodeAndName
    {
        public DateTime RegisterDateTime { get; set; }
        public bool Active { get; set; }
    }
}
