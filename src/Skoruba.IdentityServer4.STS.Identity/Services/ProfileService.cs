using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Skoruba.IdentityServer4.STS.Identity.Services
{
	public class ProfileService<TUser, TKey> : IProfileService
		where TUser : IdentityUser<TKey>
		where TKey : IEquatable<TKey>
	{
		protected UserManager<TUser> _userManager;

		public ProfileService (UserManager<TUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task GetProfileDataAsync (ProfileDataRequestContext context)
		{
			var user = await _userManager.GetUserAsync(context.Subject);

			var claims = new List<Claim>
			{
				new Claim("UserId", user.Id.ToString()),
			};

			context.IssuedClaims.AddRange(claims);
		}

		public async Task IsActiveAsync (IsActiveContext context)
		{
			var user = await _userManager.GetUserAsync(context.Subject);
			context.IsActive = (user != null) && user.EmailConfirmed;
		}
	}
}
