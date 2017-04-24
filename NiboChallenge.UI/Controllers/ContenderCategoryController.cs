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
        private readonly IContenderCategoryAppService  _contenderCategoryAppService;

        public ContenderCategoryController(IContenderCategoryAppService contenderCategoryAppService)
        {
            _contenderCategoryAppService = contenderCategoryAppService;
        }
        // GET: api/ContenderCategory
        public IEnumerable<ContenderCategory> Get()
        {
            return _contenderCategoryAppService.GetAll();
        }

        // GET: api/ContenderCategory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ContenderCategory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ContenderCategory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ContenderCategory/5
        public void Delete(int id)
        {
        }
    }
}
