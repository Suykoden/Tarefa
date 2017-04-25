using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenger.SeedWork.DTO;

namespace NiboChallenger.Application.DTO
{
    public class TeamDTO : DtoWithCodeAndName
    {
        public Guid FirstContenderId { get; set; }
        public Guid SecondContenderId { get; set; }
        public Guid ThirdContenderId { get; set; }
    }
}
