using System;
using System.ComponentModel.DataAnnotations;

namespace HomeApplication.API.Authorization.Models.Entities.Base
{
	public abstract class CreateDateAbstract : CreatedByAbstract
	{
		[Required]
        public DateTime CreateDate { get; set; }
		public void CreatedByAuditing(string createdBy)
		{
			this.CreatedBy = createdBy;
		}
    }
}
