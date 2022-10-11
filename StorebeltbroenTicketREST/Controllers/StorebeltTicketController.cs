using Microsoft.AspNetCore.Mvc;
using StoreBaeltTicketLibrary;
using StorebeltbroenTicketREST.Manager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StorebeltbroenTicketREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorebeltTicketController : ControllerBase
    {
        private StorebeltTicketManager _mgr = new();

        // GET: api/<StorebeltTicketController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            try
            {
                return Ok(_mgr.AllCarTicketes());
            }
            catch (ArgumentException e)
            {

                return NoContent();
            }
            
        }

        // GET api/<StorebeltTicketController>/5
        [HttpGet("{LicensePlate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string LicensePlate)
        {
            try
            {
                return Ok(_mgr.GetFromLicensePlate(LicensePlate));

            }
            catch (ArgumentException e)
            {
                return NotFound(e.ParamName);
            }
            
        }

        // POST api/<StorebeltTicketController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Post([FromBody] Storebaelt car)
        {
            try
            {
                return Created("", _mgr.AddCar(car));
            }
            catch (ArgumentException e)
            {
                return NotFound(e.ParamName);
            }
            
            
        }

        //// PUT api/<StorebeltTicketController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StorebeltTicketController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
