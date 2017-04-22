using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class CompetidoresTime : EntityBase
    {
        public Guid CompetidorId { get; set; }
        public Competidor competidor { get; set; }
        public Guid TimeId { get; set; }
        public Time time { get; set; }
    }
}
