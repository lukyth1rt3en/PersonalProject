using GameArchive.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameArchive.Infrastructure
{
    public class GameRepository
    {
        private ApplicationDbContext _db { get; set; }

        public GameRepository(DbContext db)
        {
            _db = (ApplicationDbContext)db;
        }

        public IQueryable<Game> ListGames()
        {
            return from g in _db.Games
                    select g;
        }

        public void AddGame(Game game)
        {
            _db.Games.Add(game);
            _db.SaveChanges();
        }
    }
}