using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonturT.Models
{
    public class Player
    {
        [JsonIgnore]
        public int playerId { get; set; }
        //[ForeignKey("mapId")]
        //[JsonIgnore]
        //public int mapId { get; set; }
        public string name { get; set; }
        public int frags { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
    }
}