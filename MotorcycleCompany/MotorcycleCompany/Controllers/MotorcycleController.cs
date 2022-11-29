using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : ControllerBase
    {
        private readonly IServiceManager _service;
        public MotorcycleController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<MotorcycleController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.MotorcycleService.GetAllMotorcycles(false));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"dfhkfjdfh {ex.Message}");
            }
        }

        // GET api/<MotorcycleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MotorcycleController>
        [HttpPost]
        public IActionResult Post([FromBody] Motorcycle moto)
        {
            _service.MotorcycleService.CreateMoto(moto);
            _service.Save();

            return Ok();
        }

        // PUT api/<MotorcycleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MotorcycleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
