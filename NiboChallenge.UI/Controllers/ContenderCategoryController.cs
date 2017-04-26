using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenger.Application.Interface;

namespace NiboChallenge.UI.Controllers
{
    public class ContenderCategoryController : ApiController
    {
        private readonly IContenderCategoryAppService _contenderCategoryAppService;

        public ContenderCategoryController(IContenderCategoryAppService contenderCategoryAppService)
        {
            _contenderCategoryAppService = contenderCategoryAppService;
        }
        // GET: api/ContenderCategory
        public IEnumerable<ContenderCategory> Get()
        {
            return _contenderCategoryAppService.GetAll();
        }


    }
}
