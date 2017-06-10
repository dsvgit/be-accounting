using System.Web.Http;

namespace Accounting.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult GetProduct()
        {
            return Ok(new { test = "test my data" });
        }
    }
}
