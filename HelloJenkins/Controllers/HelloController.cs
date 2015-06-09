using System.Web.Http;

namespace HelloJenkins.Controllers
{
	[RoutePrefix("api/hello")]
    public class HelloController : ApiController
    {
		[Route("{name}")]
		public IHttpActionResult Post(string name)
		{
			var result = new
			{
				Message = string.Format("Hello, {0}!", name)
			};

			return this.Ok(result);
		}
    }
}