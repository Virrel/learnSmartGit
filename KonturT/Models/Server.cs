using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonturT.Models
{
    public class Server
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string endpoint { get; set; }
        //[ForeignKey("infoId")]
        //[JsonIgnore]
        public int serverInfoId { get; set; }
        public ServerInfo info { get; set; }
        //public virtual IEnumerable<Map> matches { get; set; }
    }
}