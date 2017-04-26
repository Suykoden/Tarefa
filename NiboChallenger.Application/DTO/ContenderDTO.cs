using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenger.SeedWork.DTO;

namespace NiboChallenger.Application.DTO
{
    public class ContenderDTO : DtoWithName
    {
        public int Victory { get; set; }
        public int Defeat { get; set; }
        public bool Active { get; set; }
        public DateTime RegisterDateTime { get; set; }
        public Guid ContenderCategoryId { get; set; }
        public Guid FirstSkillId { get; set; }
        public Guid SecondSkillId { get; set; }
        public string FirstSkillName { get; set; }
        public string SecondSkillName { get; set; }
        public string  CategoryName { get; set; }
    }
}
