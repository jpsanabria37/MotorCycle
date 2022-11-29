using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarageController : ControllerBase
    {
        private readonly IServiceManager _service;
        public GarageController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<GarageController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.GarageService.GetAllGarages(false));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<GarageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GarageController>
        [HttpPost]
        public IActionResult Post([FromBody] Garage garage)
        {
            _service.GarageService.CreateGarage(garage);
            _service.Save();

            return Ok();

        }

        // PUT api/<GarageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GarageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
