namespace HomeApplication.API.Authorization.Models.Entities.Base
{
	public class IsActiveAbstract : ModifyDateAbstract
	{
        public bool IsActive{ get; set; }
		public void IsActiveAuditing(bool isActive, string username)
		{
			IsActive = isActive;
			ModifiedByAuditing(username);
		}
    }
}
