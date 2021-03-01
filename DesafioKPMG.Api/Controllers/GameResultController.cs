using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        public ActionResult Post([FromBody] GameResultDto gameResultDto)
        {
            try
            {
                if (gameResultDto == null)
                    return NotFound();

                applicationServiceGameResult.Add(gameResultDto);

                return Ok("Game cadastrado!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceGameResult.GetAll());
        }
    }
}
