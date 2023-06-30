using App.Models;
using App.UseCases.Developers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/Developer")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        // GET: api/<DeveloperController>
        [HttpGet("AllDevelopers")]
        public async Task<ActionResult<List<Developer>>> GetAllDevelopers([FromServices] GetAllDevelopers getAllDevelopers)
            
        {
            return Ok(await getAllDevelopers.Execute());
        }

        // GET api/<DeveloperController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Developer>>> GetDeveloperById([FromServices] GetDeveloperById getDeveloperById, [FromRoute] int id)
        {
            return Ok(await getDeveloperById.Execute(id));
        }

        [HttpGet("name/{name}")]
        public async Task<ActionResult<List<Developer>>> GetDeveloperByName([FromServices] GetDeveloperByName getDeveloperByName, [FromRoute] string name)
        {
            return Ok(await getDeveloperByName.Execute(name));
        }

        [HttpGet("games/{name}")]
        public async Task<ActionResult<List<Game>>> GetDeveloperGames([FromServices] GetDeveloperGames getDeveloperGames, [FromRoute] string name, string rating = "All")
        {
            return Ok(await getDeveloperGames.Execute(name, rating));
        }

        // POST api/<DeveloperController>
        [HttpPost("AddNewDeveloper")]
        public async Task<IActionResult> AddDeveloper([FromServices] AddDeveloper addDeveloper, [FromBody] NewDeveloper model)
        {
            await addDeveloper.Execute(model);

            return Ok("Developer Added!");
        }

        // PUT api/<DeveloperController>/5
        [HttpPut("UpdateDeveloper/{id}")]
        public async Task<IActionResult> UpdateDeveloper([FromServices] UpdateDeveloper updateDeveloper, [FromRoute] int id, [FromBody] Developer model)
        {
            await updateDeveloper.Execute(id, model);
            return Ok("Developer Information Updated.");
        }

        // DELETE api/<DeveloperController>/5
        [HttpDelete("DeleteDeveloper/{id}")]
        public async Task<IActionResult> DeleteDeveloper([FromServices] DeleteDeveloper deleteDeveloper, [FromRoute] int id)
        {
            await deleteDeveloper.Execute(id);
            return Ok("Developer Deleted.");
        }
    }
}
