using AutoMapper;
using HomeApplication.API.Authorization.Commands;
using HomeApplication.API.Authorization.Models.Outputs;
using HomeApplication.API.Authorization.Models.Requests;
using HomeApplication.API.Authorization.Models.Responses;

namespace HomeApplication.API.Authorization.MappingProfiles
{
	public class AuthenticationMappingProfile : Profile
	{
		public AuthenticationMappingProfile()
		{
			CreateMap<AuthenticationRequest, AuthenticationCommand>();
			CreateMap<AuthenticationOutput, AuthenticationResponse>();
		}
	}
}
