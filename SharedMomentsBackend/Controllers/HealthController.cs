using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SharedMomentsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        // GET: api/<HealthController>
        [HttpGet]
        public IEnumerable<string> Get(DateTime dateTime)
        {
            return new string[] {dateTime.ToLongDateString() };
        }

        
    }
}
