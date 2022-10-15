using AutoMapper;
using HomeApplication.API.Authorization.Commands;
using HomeApplication.API.Authorization.Models.Requests;
using HomeApplication.API.Authorization.Models.Responses;
using HomeApplication.API.Authorization.Models.Responses.Base;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeApplication.API.Authorization.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[AllowAnonymous]
	public class AuthenticationController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IMediator _mediator;

		public AuthenticationController(IMapper mapper, IMediator mediator)
		{
			_mapper = mapper;
			_mediator = mediator;
		}

		[HttpPost("authenticate")]
		[ProducesResponseType(typeof(BaseResponse<AuthenticationResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> Authenticate(AuthenticationRequest authenticationRequest)
		{
			var mappedRequest = _mapper.Map<AuthenticationCommand>(authenticationRequest);
			var response = await _mediator.Send(mappedRequest);

			return Ok(response);
		}
	}
}
