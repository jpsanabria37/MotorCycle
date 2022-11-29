using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly IServiceManager service;

        public RentController(IServiceManager service)
        {
            this.service = service;
        }

        // GET: api/<RentController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(service.RentService.GetAllRents(false));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RentController>
        [HttpPost]
        public IActionResult Post([FromBody] Rent rent)
        {
            service.RentService.createRent(rent);
            service.Save();

            return Ok(rent);
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
