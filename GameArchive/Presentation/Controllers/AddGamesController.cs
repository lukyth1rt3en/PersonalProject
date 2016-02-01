using GameArchive.Domain;
using GameArchive.Services;
using GameArchive.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameArchive.Presentation.Controllers
{
    public class AddGamesController : ApiController
    {
        private GameService _gameService;

        [HttpPost]
        [Route("api/addGames/game")]
        //[Authorize]
        public IHttpActionResult AddGame(Game game)
        {
            if(ModelState.IsValid)
            {
                _gameService.Add(game.Title, game.Genre, game.MaxPlayers, game.GamingSystems, User.Identity.Name);
                return Ok();
            }
            return BadRequest("This is a bad request");
        }

        public AddGamesController(GameService gameService)
        {
            _gameService = gameService;
        }
    }
}
