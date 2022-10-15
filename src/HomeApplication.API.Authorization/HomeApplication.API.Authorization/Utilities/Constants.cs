using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeApplication.API.Authorization.Utilities
{
	public class Constants
	{
		public struct AuthenticationRequest
		{
			public const string UserNameEmptyError = "Kullanıcı adı boş olamaz!";
			public const string PasswordEmptyError = "Şifre boş olamaz!";
		}
	}
}
