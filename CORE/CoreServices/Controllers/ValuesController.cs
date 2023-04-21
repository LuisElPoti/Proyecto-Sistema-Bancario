using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoreServices.Controllers
{
    public class ValuesController : ApiController
    {

        private readonly ILog log = LogManager.GetLogger("API Logger");
        // GET api/values
        public IEnumerable<string> Get()
        {
            log.Info("Log Info Message");
            log.Debug("Log Debug Message");
            log.Error("Log Error Message");
            log.Warn("Log Warning Message");

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
