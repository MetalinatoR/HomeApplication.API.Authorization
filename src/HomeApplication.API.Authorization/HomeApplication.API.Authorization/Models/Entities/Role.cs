using HomeApplication.API.Authorization.Models.Entities.Base;

namespace HomeApplication.API.Authorization.Models.Entities
{
	public class Role : IsActiveAbstract
	{
        public string RoleName { get; set; }
    }
}
