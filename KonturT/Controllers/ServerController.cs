using KonturT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace KonturT.Controllers
{
    public static class t
    {
        public static List<Server> servs = new List<Server>();
        //IEnumerable<Map> maps;
        //IEnumerable<Player> players;
    }

    public class ServerController : ApiController
    {
        //KonturTDBContext con = new KonturTDBContext();
        /*ublic ServerController()
        {

            con.Database.Delete();
        }*/

        // GET: Get specific server by endpoint
        //[Route("server/{endpoint}/info")]
        [HttpGet]
        public HttpResponseMessage GetServer([FromUri]string endpoint)
        {
            Server s = new Server();// = con.Servers.FirstOrDefault(x => x.endpoint == endpoint);
            if (s == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.OK, s);
        }

        // PUT: Receive serverInfo
        //[Route("server/{endpoint}/info")]
        [HttpPut]
        public HttpResponseMessage PutServer([FromUri]string endpoint, [FromBody]ServerInfo si)
        {
            /*if (ModelState.IsValid)
            {
                var s = con.Servers.FirstOrDefault(x => x.endpoint == endpoint);
                if (s != null)
                {
                    s.info = si;
                    con.SaveChangesAsync();
                }
                else
                {
                    s = new Server();
                    s.endpoint = endpoint;
                    s.info = si;
                    con.Servers.Add(s);
                    con.SaveChangesAsync();
                }
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }*/
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        // GET: send specific match in specific time
        //[Route("server/{endpoint}/matches/{timestamp}")]
        [HttpGet]
        public HttpResponseMessage GetMatch([FromUri]string endpoint, [FromUri]DateTime timestamp)
        {
            if (true)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }

        // PUT: specific match in specific time
        [Route("server/{endpoint}/matches/{timestamp}")]
        [HttpGet]
        public HttpResponseMessage PutMatch([FromUri]string endpoint, [FromUri]DateTime timestamp)
        {
            if (true)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
        
        // GET: Send specific server stats
        //[Route("server/{endpoint}/stats")]
        [HttpGet]
        public HttpResponseMessage GetServerStats([FromUri]string endpoint)
        {
            if (true)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
        
        // GET: Send all servers
        //[Route("server/info")]
        [HttpGet]
        public HttpResponseMessage GetAllServersStats()
        {
            if (true)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
    }

    /*public class NotFoundWithMessageResult : IHttpActionResult
    {
        private string message;

        public NotFoundWithMessageResult(string message)
        {
            this.message = message;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
            response.Content = new StringContent(message);
            return Task.FromResult(response);
        }
    }*/
}
