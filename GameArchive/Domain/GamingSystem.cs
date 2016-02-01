using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameArchive.Domain
{
    public class GamingSystem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Game> Games { get; set; }
    }
}