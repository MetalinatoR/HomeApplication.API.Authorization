using System;

namespace HomeApplication.API.Authorization.Models.Entities.Base
{
	public abstract class ModifyDateAbstract : ModifiedByAbstract
	{
        public DateTime ModifyDate { get; set; }
		public void ModifiedByAuditing(string modifiedBy)
		{
			this.ModifiedBy = modifiedBy;
		}
    }
}
