using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Application.Interfaces;
using DesafioKPMG.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioKPMG.Api.Controllers
{
    [Route("leaderboard")]
    public class LeaderboardController : ControllerBase
    { 
        private readonly IApplicationServiceLeaderboard applicationServiceLeaderboard;
        public LeaderboardController(IApplicationServiceLeaderboard applicationServiceLeaderboard)
        {
            this.applicationServiceLeaderboard = applicationServiceLeaderboard;
        }

        [HttpPost]
        public async Task<ActionResult<Leaderboard>> Post([FromBody] LeaderboardDto LeaderboardDto)
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
        public async Task<ActionResult<IEnumerable<Leaderboard>>> Get()
        {
            return Ok(applicationServiceLeaderboard.BestPlayers());
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceLeaderboard.GetById(id));
        }
    }
}
