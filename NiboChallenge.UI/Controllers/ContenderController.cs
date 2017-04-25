using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenger.Application.Interface;
using NiboChallenger.Application.DTO;

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
        public IEnumerable<ContenderDTO> Get()
        {

            return _contenderAppServicecompetidorAppService.GetContenderDetailed();
        }

        // GET: api/Contender/5
        public Contender Get(Guid id)
        {
            //Return a contender selected by the Id
            return _contenderAppServicecompetidorAppService.GetById(id);
        }

        // POST: api/Contender
        public void Post(Contender contender)
        {
            contender.Id = Guid.NewGuid();
            contender.RegisterDateTime = DateTime.Now;
            contender.Active = true;
            _contenderAppServicecompetidorAppService.Add(contender);
        }

        // PUT: api/Contender/5
        [HttpPut]
        public void DeleteContender(Contender contender)
        {
            contender.Active = false;
            _contenderAppServicecompetidorAppService.Update(contender);
        }

        // DELETE: api/Contender/5
        public void Delete(int id)
        {
        }
    }
}
