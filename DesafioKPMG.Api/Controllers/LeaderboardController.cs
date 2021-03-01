using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DesafioKPMG.Api.Controllers
{
    public class LeaderboardController : ControllerBase
    { 
        private readonly IApplicationServiceLeaderboard applicationServiceLeaderboard;
        public LeaderboardController(IApplicationServiceLeaderboard applicationServiceLeaderboard)
        {
            this.applicationServiceLeaderboard = applicationServiceLeaderboard;
        }

        [HttpPost]
        public ActionResult Post([FromBody] LeaderboardDto LeaderboardDto)
        {
            try
            {
                if (LeaderboardDto == null)
                    return NotFound();

                applicationServiceLeaderboard.Add(LeaderboardDto);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceLeaderboard.GetAll());
        }
    }
}
