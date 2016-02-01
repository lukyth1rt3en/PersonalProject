using GameArchive.Domain;
using GameArchive.Infrastructure;
using GameArchive.Services.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameArchive.Services
{
    public class GameService
    {
        private GameRepository _gameRepo;
        private ApplicationUserManager _userRepo;

        public IList<GameDTO> GamesList()
        {
            return (from g in _gameRepo.ListGames()
                    select new GameDTO()
                    {
                        Id = g.Id,
                        Title = g.Title,
                        Genre = g.Genre,
                        MaxPlayers = g.MaxPlayers,
                        GamingSystems = (from s in g.GamingSystems
                                         select new GamingSystemDTO()
                                         {
                                             Name = s.Name,

                                         }).ToList()
                    }).ToList();
        }  
        
        public void Add(string title, string genra, int maxplayers, IList<GamingSystem> gamingSystems, string userName)
        {
            var user = _userRepo.FindByName(userName);

            var game = new Game()
            {
                User = user,
                Title = title,
                Genre = genra,
                MaxPlayers = maxplayers,
                GamingSystems = gamingSystems 
            };
        }                    

        public GameService (GameRepository gameRepo, ApplicationUserManager userRepo)
        {
            _gameRepo = gameRepo;
            _userRepo = userRepo;
        }
    }
}