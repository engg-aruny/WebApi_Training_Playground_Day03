using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using WebApi_Training_Playground_Day03.Auth;

[assembly: OwinStartup(typeof(WebApi_Training_Playground_Day03.OwinStartup))]

namespace WebApi_Training_Playground_Day03
{
	public class OwinStartup
	{
		public void Configuration(IAppBuilder app)
		{
			// Enable CORS (cross origin resource sharing) for making request using browser from different domains
			app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

			OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
			{
				AllowInsecureHttp = true,

				//The Path For generating the Token
				TokenEndpointPath = new PathString("/token"),

				//Setting the Token Expired Time (24 hours)
				AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),

				//AuthorizationServerProvider class will validate the user credentials
				Provider = new AuthorizationServerProvider()
			};


			//Token Generations
			app.UseOAuthAuthorizationServer(options);
			app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

			HttpConfiguration config = new HttpConfiguration();
			WebApiConfig.Register(config);
		}
	}
}
