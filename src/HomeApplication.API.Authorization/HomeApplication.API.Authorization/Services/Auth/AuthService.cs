using HomeApplication.API.Authorization.Commands;
using HomeApplication.API.Authorization.Models.Outputs;
using HomeApplication.API.Authorization.Models.Responses.Base;
using HomeApplication.API.Authorization.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplication.API.Authorization.Services.Auth
{
	public class AuthService : IAuthService
	{
		private readonly JwtOptions _jwtOptions;
		public AuthService(IOptions<JwtOptions> options)
		{
			_jwtOptions = options.Value;
		}

		public async Task<BaseResponse<AuthenticationOutput>> Authenticate(AuthenticationCommand command)
		{
			var response = new BaseResponse<AuthenticationOutput>();
			var tokenHandler = new JwtSecurityTokenHandler();
			var tokenKey = Encoding.UTF8.GetBytes(_jwtOptions.Key);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Claims = new Dictionary<string, object> 
				{ 
					{ ClaimTypes.NameIdentifier, command.Username },
					{ ClaimTypes.Role, "Admin" }
				},
				Expires = DateTime.UtcNow.AddMinutes(_jwtOptions.Expires),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature),
				Audience = _jwtOptions.Audience,
				Issuer = _jwtOptions.Issuer
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);

			response.Data = new AuthenticationOutput()
			{
				AuthenticationToken = tokenHandler.WriteToken(token),
				ExpirationDate = tokenDescriptor.Expires,
				RefreshToken = CreateRefreshToken()
			};

			return response;
		}

		public string CreateRefreshToken()
		{
			return Convert.ToBase64String(BitConverter.GetBytes(RandomNumberGenerator.GetInt32(64)));
		}
	}
}
