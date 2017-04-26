using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;

namespace NiboChallenge.UI.Controllers
{
    public class SkillController : ApiController
    {
        private readonly ISkillAppService _skillAppService;

        public SkillController(ISkillAppService skillAppService)
        {
            _skillAppService = skillAppService;
        }
        // GET: api/Habilidade
        public IEnumerable<Skill> Get()
        {
            return _skillAppService.GetAll();
        }

    }
}
