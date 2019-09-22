using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Plumsail.CommonLib.DataContracts.RequestResult;
using Plumsail.CommonLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.Web.Core.MVCFilters
{
    public class ResponseWrapperAttribute : ExceptionFilterAttribute, IResultFilter, IExceptionFilter
    {
        public ResponseWrapperAttribute(ILogger<ExceptionFilterAttribute> logger) : base(logger)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var result = context.Result;
            if (result is ObjectResult)
            {
                var objRes = ((ObjectResult)result).Value;
                context.Result = new JsonResult(new SuccessResult<object>(objRes));
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {

        }
    }

    //  public class ResponseWrapperAttribute : Attribute,

    public class ExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        private readonly ILogger _logger;

        public ExceptionFilterAttribute(ILogger<ExceptionFilterAttribute> logger)
        {
            _logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            string errorMessage = string.Empty;
            string errorCode = null;

            var exception = context.Exception;
            if (exception is UserFriendlyException)
            {
                var friendlyExcpetion = exception as UserFriendlyException;
                errorMessage = friendlyExcpetion.Message;
                errorCode = friendlyExcpetion.ErrorCode;
            }
            else
            {
                errorMessage = "UnexpectedError";
            }
            _logger.LogError(exception, exception.Message);

            var errorResult = new ErrorResult(errorMessage, errorCode);

            context.Result = new JsonResult(errorResult);
        }
    }
}
