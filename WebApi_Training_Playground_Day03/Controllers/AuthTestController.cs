using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace WebApi_Training_Playground_Day03.Controllers
{
    public class AuthTestController: ApiController
    {
	    //This resource is For all types of role
	    [Authorize(Roles = "SuperAdmin, Admin, User")]
	    [HttpGet]
	    [Route("api/authTest/resource1")]
	    public IHttpActionResult GetResource1()
	    {
		    var identity = (ClaimsIdentity)User.Identity;
		    return Ok("Hello: " + identity.Name);
	    }

	    //This resource is only For Admin and SuperAdmin role
	    [Authorize(Roles = "SuperAdmin, Admin")]
	    [HttpGet]
	    [Route("api/authTest/resource2")]
	    public IHttpActionResult GetResource2()
	    {
		    var identity = (ClaimsIdentity)User.Identity;
		    var Email = identity.Claims.FirstOrDefault(c => c.Type == "Email").Value;
		    var UserName = identity.Name;

		    return Ok("Hello " + UserName + ", Your Email ID is :" + Email);
	    }


	    //This resource is only For SuperAdmin role
	    [Authorize(Roles = "SuperAdmin")]
	    [HttpGet]
	    [Route("api/authTest/resource3")]
	    public IHttpActionResult GetResource3()
	    {
		    var identity = (ClaimsIdentity)User.Identity;
		    var roles = identity.Claims
			    .Where(c => c.Type == ClaimTypes.Role)
			    .Select(c => c.Value);
		    return Ok("Hello " + identity.Name + "Your Role(s) are: " + string.Join(",", roles.ToList()));
	    }
    }
}
