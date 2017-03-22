using Owin;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace OwinSelfhostSample
{

    public abstract class BaseController : ApiController
    {
        public BaseController()
        {
            OwinRequestScopeContext.Current.Items["Data"] = "Test Data";
        }        
    }

    public class MainController : BaseController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            var value = OwinRequestScopeContext.Current.Items["Data"].ToString();
            return new string[] { "value1", value };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}