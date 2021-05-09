using Bakogeorgos_test.Models;
using Bakogeorgos_test.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Controllers
{
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _service;
        public MatchController(IMatchService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllMatches()
        {
            try
            {
                return Ok(await _service.GetAllMatches());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMatchById(int id)
        {
            try
            {
              return Ok(await _service.GetMatchById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateMatch([FromBody] Match match)
        {
            try 
            {
                var id = await _service.CreateMatch(match);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateMatch([FromBody]Match match)
        {
            try
            {
                return Ok(await _service.UpdateMatch(match));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatch(int id) 
        {
            return Ok(await _service.DeleteMatch(id));
        }


    }
}
