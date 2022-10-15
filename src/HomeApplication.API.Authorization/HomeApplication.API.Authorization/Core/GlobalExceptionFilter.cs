using HomeApplication.API.Authorization.Core.ExceptionResult;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace HomeApplication.API.Authorization.Core
{
	public class GlobalExceptionFilter : ExceptionFilterAttribute
	{
		private IHostEnvironment _environment;
		private ILogger _logger;

		public GlobalExceptionFilter(IHostEnvironment environment, ILoggerFactory loggerFactory)
		{
			_environment = environment;
			_logger = loggerFactory.CreateLogger<GlobalExceptionFilter>();
		}

		public override void OnException(ExceptionContext context)
		{
			context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
			if (_environment.IsProduction())
			{
				context.Result = new JsonResult(new List<ServiceResult>()
				{
					new ServiceResult("InternalServerError", context.Exception.Message)
				});
			}
			else
			{
				context.Result = new JsonResult(new List<ServiceResult>()
				{
					new ServiceResult("InternalServerError", $"{context.Exception.Message} - {context.Exception.InnerException?.Message} - {context.Exception.StackTrace}")
				});
			}
			_logger.LogError("Internal Server Error \n" +
				$"{context.Exception.Message} - {context.Exception.InnerException?.Message} - {context.Exception.StackTrace}");
		}
	}
}
