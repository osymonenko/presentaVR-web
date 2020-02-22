using Newtonsoft.Json;
using System.Web.Http;

namespace presentaVR.Controllers
{
    public class AppConnectController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetTestJson(string id)
        {
            var jsObj = new JsonObjTest() { Id = id };
            return Ok(jsObj);
        }

        private class JsonObjTest
        {
            public string Id { get; set; }
        }
    }
}
