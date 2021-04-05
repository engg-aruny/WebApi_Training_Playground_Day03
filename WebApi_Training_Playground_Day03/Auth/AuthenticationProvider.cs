using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using WebApi_Training_Playground_Day03.Repositories;

namespace WebApi_Training_Playground_Day03.Auth
{
	public class AuthenticationProvider : OAuthAuthorizationServerProvider
	{
		private readonly IUserMasterRepository userMasterRepository;

		public AuthenticationProvider()
		{
			userMasterRepository = new UserMasterRepository();
		}

		public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
		{
			context.Validated();
		}

		public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
		{
			var user = userMasterRepository.ValidateUser(context.UserName, context.Password);
			if (user == null)
			{
				context.SetError("invalid_grant", "Provided username and password is incorrect");
				return;
			}
			var identity = new ClaimsIdentity(context.Options.AuthenticationType);
			identity.AddClaim(new Claim(ClaimTypes.Role, user.Roles));
			identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
			identity.AddClaim(new Claim("Email", user.EmailId));

			context.Validated(identity);
		}
	}
}
