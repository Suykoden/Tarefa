using SeedWork.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiboChallenger.Application.DTO
{
    public class ContenderDto: DtoWithCodeAndName
    {
        public int Victory { get; set; }
        public int Defeat { get; set; }
        public bool Ativo { get; set; }
        public DateTime RegisterDateTime { get; set; }
        public Guid ContenderCategoryId { get; set; }
        public Guid FirstSkillId { get; set; }
        public Guid SecondSkillId { get; set; }
      
    }
}
