using FluentValidation;
using HomeApplication.API.Authorization.Utilities;
using Microsoft.AspNetCore.Http;
using System;

namespace HomeApplication.API.Authorization.Models.Requests
{
	[Serializable]
	public class AuthenticationRequest
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class AuthenticationRequestValidator : AbstractValidator<AuthenticationRequest>
	{
		public AuthenticationRequestValidator()
		{
			RuleFor(x => x.Username).NotNull().WithErrorCode(StatusCodes.Status400BadRequest.ToString()).WithMessage(Constants.AuthenticationRequest.UserNameEmptyError);
			RuleFor(x => x.Password).NotNull().WithErrorCode(StatusCodes.Status400BadRequest.ToString()).WithMessage(Constants.AuthenticationRequest.PasswordEmptyError);
		}
	}
}
