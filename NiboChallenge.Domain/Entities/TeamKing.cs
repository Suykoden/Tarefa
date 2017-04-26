using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class TeamKing:EntityBase
    {
        public string WinnerTeamName { get; set; }
        public  bool Active { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
