using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {

        private readonly IServiceManager _service;
        public AgencyController(IServiceManager service)
        {
            _service = service;
        }
        // GET: api/<AgencyController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.AgencyService.GetAllAgenciesDTO(false));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"controllador {ex.Message}");
            }
           
        }

        // GET api/<AgencyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AgencyController>
        [HttpPost]
        public IActionResult Post([FromBody] Agency agency)
        {
            _service.AgencyService.CreateAgency(agency);
            _service.Save();

            return Ok();
        }

        // PUT api/<AgencyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AgencyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
