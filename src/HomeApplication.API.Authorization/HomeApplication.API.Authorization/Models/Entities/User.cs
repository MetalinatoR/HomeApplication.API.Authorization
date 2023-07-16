using HomeApplication.API.Authorization.Models.Entities.Base;

namespace HomeApplication.API.Authorization.Models.Entities
{
	public class User : IsActiveAbstract
	{
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
