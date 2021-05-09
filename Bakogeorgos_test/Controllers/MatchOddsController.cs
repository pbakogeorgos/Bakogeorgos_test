using Bakogeorgos_test.Models;
using Bakogeorgos_test.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Controllers
{
    public class MatchOddsController : ControllerBase
    {
        private readonly IMatchOddService _service;
        public MatchOddsController(IMatchOddService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllOdds")]
        public async Task<IActionResult> GetAllMatchOdds()
        {
            try
            {
                return Ok(await _service.GetAllMatchOdds());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }

        }

        [HttpGet("{oddsId}")]
        public async Task<IActionResult> GetMatchOddsById(int oddsId)
        {
            try
            {
                return Ok(await _service.GetMatchOddsById(oddsId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }

        [HttpPost]
        [Route("CreateOdds")]
        public async Task<IActionResult> CreateMatchOdds([FromBody] MatchOdd matchOdd)
        {
            try
            {
                var id = await _service.CreateMatchOdds(matchOdd);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }

        [HttpPut]
        [Route("UpdateOdds")]
        public async Task<IActionResult> UpdateMatch([FromBody] MatchOdd matchOdd)
        {
            try
            {
                return Ok(await _service.UpdateMatchOdds(matchOdd));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }

        }

        [HttpDelete("{oddsId}")]
        public async Task<IActionResult> DeleteMatch(int oddsId)
        {
            return Ok(await _service.DeleteMatchOdds(oddsId));
        }
    }
}
