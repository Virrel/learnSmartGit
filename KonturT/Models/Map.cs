using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonturT.Models
{
    public class Map
    {
        [JsonIgnore]
        public int mapId { get; set; }
        [JsonIgnore]
        public DateTime timestamp { get; set; }
        [JsonIgnore]
        public string serverEndpoint { get; set; }
        public string name { get; set; }
        public string gameMode { get; set; }
        public int fragLimit { get; set; }
        public int timeLimit { get; set; }
        public float timeElapsed { get; set; }
        
        private ICollection<Player> _scoreboard;

        public virtual ICollection<Player> Scoreboard
        {
            get {
                return (ICollection<Player>)_scoreboard.OrderByDescending(x => x.frags + x.kills);
            }
            set { _scoreboard = value; }
        }

    }
}