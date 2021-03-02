using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Application.Interfaces;
using DesafioKPMG.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioKPMG.Api.Controllers
{
    [Route("gameresult")]
    public class GameResultController : ControllerBase
    {
        private readonly IApplicationServiceGameResult applicationServiceGameResult;

        public GameResultController(IApplicationServiceGameResult applicationServiceGameResult)
        {
            this.applicationServiceGameResult = applicationServiceGameResult;
        }

        [HttpPost]
        public async Task<ActionResult<GameResult>> Post([FromBody] GameResultDto gameResultDto)
        {
            try
            {
                if (gameResultDto == null)
                    return NotFound();

                applicationServiceGameResult.Add(gameResultDto);

                return Ok(new { message = "Cadastrado" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Não foi possível criar ", ex });
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameResult>>> Get()
        {
            return Ok(applicationServiceGameResult.GetAll());
        }
    }
}
