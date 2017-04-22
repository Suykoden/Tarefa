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
    public class ClasseCampeaoController : ApiController
    {
        private readonly IClasseCampeaoAppService _classeCampeaoAppService;

        public ClasseCampeaoController(IClasseCampeaoAppService classeCampeaoAppService)
        {
            _classeCampeaoAppService = classeCampeaoAppService;
        }
        // GET: api/ClasseCampeao
        public IEnumerable<ClasseCampeao> Get()
        {
            return _classeCampeaoAppService.GetAll();
        }

        // GET: api/ClasseCampeao/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ClasseCampeao
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ClasseCampeao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ClasseCampeao/5
        public void Delete(int id)
        {
        }
    }
}
