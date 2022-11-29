using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IServiceManager _service;
        public PhoneController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<PhoneController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.PhoneService.GetAllPhones(false));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<PhoneController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PhoneController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhoneController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhoneController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
