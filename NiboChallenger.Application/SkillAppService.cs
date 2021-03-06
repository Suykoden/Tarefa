﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;

namespace NiboChallenger.Application
{
    public class SkillAppService : AppServiceBase<Skill>, ISkillAppService
    {
        private readonly ISkillService _skillService;

        public SkillAppService(ISkillService skillService) :
            base(skillService)
        {
            _skillService = skillService;
        }
    }
}
