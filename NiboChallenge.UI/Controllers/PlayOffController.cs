﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;
using NiboChallenger.Application.DTO;

namespace NiboChallenge.UI.Controllers
{
    public class PlayOffController : ApiController
    {
        private readonly IPlayoffAppService _playofffAppService;


        public PlayOffController(IPlayoffAppService playofffAppService)
        {
            _playofffAppService = playofffAppService;
        }

        // GET: api/PlayOff
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PlayOff/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PlayOff
        public void Post(Playoffs playoff)
        {
            ///Happens because from angular it cames from object: tournament, and fills the id with tournament id, but here
            //we are dealing with Playoff object, could be corrected with a hidden property or something
            playoff.TournamentId = playoff.Id;
            playoff.Id = Guid.NewGuid();
            _playofffAppService.Add(playoff);

        }

        // PUT: api/PlayOff/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PlayOff/5
        public void Delete(int id)
        {
        }
    }
}
