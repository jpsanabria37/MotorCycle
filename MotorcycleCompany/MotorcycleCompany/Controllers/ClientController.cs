using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IServiceManager _service;
        public ClientController(IServiceManager service)
        {
            _service = service;
        }


        // GET: api/<ClientController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.ClientService.GetAllClients(false));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientController>
        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            _service.ClientService.CreateClient(client);
            _service.Save();

            return Ok();
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
