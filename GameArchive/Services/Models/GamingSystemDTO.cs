using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameArchive.Services.Models
{
    public class GamingSystemDTO
    {
        public string Name { get; set; }
        public IList<GameDTO> Games { get; set; }
    }
}