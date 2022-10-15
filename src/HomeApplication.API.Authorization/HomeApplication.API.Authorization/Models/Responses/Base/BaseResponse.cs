using HomeApplication.API.Authorization.Core.ExceptionResult;
using System.Collections.Generic;

namespace HomeApplication.API.Authorization.Models.Responses.Base
{
	public class BaseResponse<T>
	{
		public IList<ServiceResult> ErrorMessages{ get; set; } = new List<ServiceResult>();
		public bool HasError { get; set; }
		public T Data{ get; set; }

		public void AddError(string errorCode, string errorMessage)
		{
			HasError = true;
			ErrorMessages.Add(new ServiceResult(errorCode, errorMessage));
		}
	}
}
