using System.Web.Http;

namespace AzureApiTest2.Controllers
{
    public class XmasController : ApiController
    {
        [HttpGet]
        public string OnTheNthDay(int day)
        {
            return "On the First day of Christmas my true love sent to me a Partridge in a Pear Tree.";
        }
    }
}