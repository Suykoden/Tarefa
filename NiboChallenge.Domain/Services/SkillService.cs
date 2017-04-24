using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Repositories;
using NiboChallenge.Domain.Interfaces.Services;

namespace NiboChallenge.Domain.Services
{
    public class SkillService : ServiceBase<Skill>, ISkillService
    {
        private ISkillRepository _SkillRepository;
        public SkillService(ISkillRepository skillRepository) :
            base(skillRepository)
        {
            _SkillRepository = skillRepository;
        }
    }
}
