namespace HomeApplication.API.Authorization.Core.ExceptionResult
{
	public class ServiceResult
	{
		public string ErrorCode { get; set; }
		public string ErrorMessage { get; set; }

		public ServiceResult()
		{
		}

		public ServiceResult(string errorCode, string errorMessage)
		{
			ErrorCode = errorCode;
			ErrorMessage = errorMessage;
		}
	}
}
