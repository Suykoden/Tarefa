using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class ContendersTeam : EntityBase
    {
        public Guid ContenderId { get; set; }
        public Contender Contender { get; set; }
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
    }
}
