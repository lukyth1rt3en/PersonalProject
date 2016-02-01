using GameArchive.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameArchive.Presentation.Controllers
{
    public class GamesController : ApiController
    {
        private GameService _gameService;

        public GamesController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        [Route("api/games/list")]
        //[Authorize]
        public IHttpActionResult GameList()
        {
            if (ModelState.IsValid)
            {
                return Ok(_gameService.GamesList());
            }
            return BadRequest("This is a bad request");
        }
    }
}
