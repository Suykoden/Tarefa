using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Contender : EntityWithName
    {
        public int Victory { get; set; }
        public int Defeat { get; set; }
        public bool Active { get; set; }
        public DateTime RegisterDateTime { get; set; }
        public Guid ContenderCategoryId { get; set; }
        public ContenderCategory ContenderCategory { get; set; }
        public Guid FirstSkillId { get; set; }
        public Skill FirstSkill { get; set; }
        public Guid SecondSkillId { get; set; }
        public Skill SecondSkill { get; set; }
    }
}
