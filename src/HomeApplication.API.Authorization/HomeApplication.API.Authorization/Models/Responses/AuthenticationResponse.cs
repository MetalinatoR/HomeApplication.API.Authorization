using Microsoft.IdentityModel.Tokens;
using System;

namespace HomeApplication.API.Authorization.Models.Responses
{
	public class AuthenticationResponse
	{
		public string AuthenticationToken { get; set; }
		public string RefreshToken { get; set; }
		public DateTime? ExpirationDate { get; set; }
	}
}
