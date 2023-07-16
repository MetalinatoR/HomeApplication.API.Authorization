namespace HomeApplication.API.Authorization.Models.Entities.Base
{
	public class ModifiedByAbstract : CreateDateAbstract
	{
        public string ModifiedBy { get; set; }
    }
}