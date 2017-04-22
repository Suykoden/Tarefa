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
    public class TimesController : ApiController
    {
        private readonly ITimeAppService _timeAppService;

        public TimesController(ITimeAppService timeAppService)
        {
            _timeAppService = timeAppService;
        }


        // GET: api/Times
        public IEnumerable<Time> Get()
        {
            return _timeAppService.GetAll();
        }

        // GET: api/Times/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Times
        public void Post([FromBody]Time time)
        {
            time.Id = Guid.NewGuid();
            time.Ativo = true;
            time.DataCadastro = DateTime.Now;
            _timeAppService.Add(time);
        }

        // PUT: api/Times/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Times/5
        public void Delete(int id)
        {
        }
    }
}
