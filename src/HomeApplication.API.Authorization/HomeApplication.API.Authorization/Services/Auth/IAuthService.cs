using HomeApplication.API.Authorization.Commands;
using HomeApplication.API.Authorization.Models.Outputs;
using HomeApplication.API.Authorization.Models.Responses.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeApplication.API.Authorization.Services.Auth
{
	public interface IAuthService
	{
		public Task<BaseResponse<AuthenticationOutput>> Authenticate(AuthenticationCommand command);
	}
}
