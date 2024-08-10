using Microsoft.AspNetCore.Mvc;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SharedMomentsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        IResourceService _resourceService;
        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }
        // GET: api/<ResourceController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ResourceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResourceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResourceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResourceController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            ResultPattern<bool> result = await _resourceService.DeleteResource(id);

            return StatusCode(result.StatusCode, result);
        }
    }
}
