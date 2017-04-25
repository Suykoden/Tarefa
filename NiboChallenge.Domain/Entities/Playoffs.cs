using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Playoffs:EntityBase
    {
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
        public bool Finished { get; set; }
    }
}
