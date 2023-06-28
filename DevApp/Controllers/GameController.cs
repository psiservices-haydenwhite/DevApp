using App.Models;
using App.UseCases.Games;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // GET: api/<GameController>
        [HttpGet("AllGames")]
        public async Task<ActionResult<List<Game>>> GetAllGames([FromServices] GetAllGames getAllGames)
        {
            return Ok(await getAllGames.Execute());
        }

        // GET api/<GameController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Game>>> GetGameById([FromServices] GetGameById getGameById, [FromRoute] int id)
        {
            return Ok(await getGameById.Execute(id));
        }

        [HttpGet("name/{name}")]
        public async Task<ActionResult<List<Game>>> GetGameByName([FromServices] GetGameByName getGameByName, [FromRoute] string name, string developer)
        {
            return Ok(await getGameByName.Execute(name, developer));
        }

        [HttpGet("developer/{name}")]
        public async Task<ActionResult<List<Developer>>> GetGameDev([FromServices] GetGameDev getGameDev, [FromRoute] string name)
        {
            return Ok(await getGameDev.Execute(name));
        }

        // POST api/<GameController>
        [HttpPost("AddNewGame")]
        public async Task<IActionResult> AddGame([FromServices] AddGame addGame, [FromBody] Game model)
        {
            await addGame.Execute(model);

            return Ok("Game Added!");
        }

        // PUT api/<GameController>/5
        [HttpPut("UpdateGame/{id}")]
        public async Task<IActionResult> UpdateGame([FromServices] UpdateGame updateGame, [FromRoute] int id, [FromBody] Game model)
        {
            await updateGame.Execute(id, model);
            return Ok("Game Information Updated.");
        }

        // DELETE api/<GameController>/5
        [HttpDelete("DeleteGame/{id}")]
        public async Task<IActionResult> DeleteGame([FromServices] DeleteGame deleteGame, [FromRoute] int id)
        {
            await deleteGame.Execute(id);
            return Ok("Game Deleted.");
        }
    }
}
