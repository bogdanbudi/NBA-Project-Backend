using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scoreboard.Application.Features.Games.Queries.GetGamesQuery;
using System.Net;

namespace Scoreboard.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GameController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<GamesVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<GamesVm>>> GetAllGames()
        {
            var query = new GetGamesListQuery();
            var games = await _mediator.Send(query);
            return Ok(games);
        }
    }
}
