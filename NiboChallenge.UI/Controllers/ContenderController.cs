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
    public class ContenderController : ApiController
    {
        private readonly IContenderAppService _contenderAppServicecompetidorAppService;

        public ContenderController(IContenderAppService contenderAppService)
        {
            _contenderAppServicecompetidorAppService = contenderAppService;
        }
        // GET: api/Contender
        public IEnumerable<Contender> Get()
        {

            return _contenderAppServicecompetidorAppService.GetAll();
        }

        // GET: api/Contender/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contender
        public void Post(Contender contender)
        {
            contender.Id = Guid.NewGuid();
            contender.RegisterDateTime = DateTime.Now;
            contender.Ativo = true;
            _contenderAppServicecompetidorAppService.Add(contender);
        }

        // PUT: api/Contender/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contender/5
        public void Delete(int id)
        {
        }
    }
}
