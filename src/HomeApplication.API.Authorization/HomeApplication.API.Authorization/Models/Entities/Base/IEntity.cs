using System.ComponentModel.DataAnnotations;

namespace HomeApplication.API.Authorization.Models.Entities.Base
{
	public interface IEntity
	{
		[Key]
        public int Id { get; set; }
    }
}
