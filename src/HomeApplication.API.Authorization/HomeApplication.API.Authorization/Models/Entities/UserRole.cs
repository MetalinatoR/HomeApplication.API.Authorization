using HomeApplication.API.Authorization.Models.Entities.Base;

namespace HomeApplication.API.Authorization.Models.Entities
{
	public class UserRole : IsActiveAbstract
	{
        public virtual User user { get; set; }
		public virtual Role role { get; set; }
    }
}
