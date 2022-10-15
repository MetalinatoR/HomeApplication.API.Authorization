using HomeApplication.API.Authorization.Models.Args;
using MediatR;
using HomeApplication.API.Authorization.Models.Responses.Base;
using HomeApplication.API.Authorization.Models.Outputs;

namespace HomeApplication.API.Authorization.Commands
{
	public class AuthenticationCommand : AuthenticationArgs, IRequest<BaseResponse<AuthenticationOutput>>
	{
	}
}
