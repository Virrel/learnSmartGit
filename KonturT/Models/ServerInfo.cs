using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonturT.Models
{
    public class ServerInfo
    {
        [JsonIgnore]
        public int infoId { get; set; }
        public string name { get; set; }
        public string[] gameModes { get; set; }
    }
}