namespace HomeApplication.API.Authorization.Options
{
	public class JwtOptions
	{
		public string Key { get; set; }
		public string Audience { get; set; }
		public string Issuer { get; set; }
		public int Expires { get; set; }
	}
}
