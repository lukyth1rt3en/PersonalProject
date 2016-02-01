using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameArchive.Domain
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int MaxPlayers { get; set; }
        public IList<GamingSystem> GamingSystems { get; set; }
    }
}