using HomeApplication.API.Authorization.Models.Outputs;
using HomeApplication.API.Authorization.Models.Responses.Base;
using HomeApplication.API.Authorization.Services.Auth;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using System.Threading;
using System.Threading.Tasks;

namespace HomeApplication.API.Authorization.Commands
{
	public class AuthenticationCommandHandler : IRequestHandler<AuthenticationCommand, BaseResponse<AuthenticationOutput>>
	{
		private readonly IAuthService _authService;
		public AuthenticationCommandHandler(IAuthService authService)
		{
			_authService = authService;
		}

		public async Task<BaseResponse<AuthenticationOutput>> Handle(AuthenticationCommand command, CancellationToken cancellationToken)
		{
			return await _authService.Authenticate(command);
		}
	}
}
