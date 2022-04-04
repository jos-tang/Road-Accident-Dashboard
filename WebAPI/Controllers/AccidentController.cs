using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using WebAPI.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccidentController : ControllerBase
    {
        private readonly IAccidentRepository _accidentRepository;
        public AccidentController(IAccidentRepository accidentRepository)
        {
            _accidentRepository = accidentRepository;

        }
        [HttpGet("StartHour")]
        public async Task<ActionResult<IEnumerable<Accident>>> GetStartHourFrequency()
        {      
            var address = await _accidentRepository.GetStartHourCount();

            return Ok(address);
        }
    }
}