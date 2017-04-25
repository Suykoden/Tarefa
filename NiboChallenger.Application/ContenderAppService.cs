using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.DTO;
using NiboChallenger.Application.Interface;

namespace NiboChallenger.Application
{
    public class ContenderAppService : AppServiceBase<Contender>, IContenderAppService
    {
        private readonly IContenderService _contenderService;
        private readonly IContenderCategoryService _contenderCategory;

        public ContenderAppService(IContenderService contenderService, IContenderCategoryService contenderCategory)
        : base(contenderService)
        {
            _contenderService = contenderService;
            _contenderCategory = contenderCategory;
        }

        public IEnumerable<ContenderDTO> GetContenderDetailed()
        {
            var _Contenders = _contenderService.GetAll();
            var _Category = _contenderCategory.GetAll();

            return (from c in _Contenders
                    join ct in _Category on c.ContenderCategoryId equals ct.Id

                    where (c.Active == true)
                    select new ContenderDTO()
                    {
                        Id = c.Id,
                        Name = c.Name,
                        CategoryName = ct.Name,
                        Active = c.Active,
                        Victory = c.Victory,
                        Defeat = c.Defeat,
                        RegisterDateTime = c.RegisterDateTime,
                        ContenderCategoryId = c.ContenderCategoryId,
                        FirstSkillId = c.FirstSkillId,
                        SecondSkillId = c.SecondSkillId
                        
                    });
        }
    }
}
