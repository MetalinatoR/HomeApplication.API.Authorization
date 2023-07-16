using System.ComponentModel.DataAnnotations;

namespace HomeApplication.API.Authorization.Models.Entities.Base
{
	public abstract class CreatedByAbstract
	{
		[Required]
        public string CreatedBy { get; set; }
    }
}