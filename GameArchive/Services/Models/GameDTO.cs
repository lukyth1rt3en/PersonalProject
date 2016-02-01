using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameArchive.Services.Models
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int MaxPlayers { get; set; }
        public IList<GamingSystemDTO> GamingSystems { get; set; }
    }
}