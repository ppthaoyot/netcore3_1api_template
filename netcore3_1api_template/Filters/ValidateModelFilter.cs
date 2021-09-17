using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using netcore3_1api_template.Models;
using Serilog;
using System;

namespace netcore3_1api_template.Filters
{
    public class ValidateModelFilter : IActionFilter, IOrderedFilter
    {
        public int Order { get; set; } = int.MinValue;

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var result = ResponseResult.Failure<object>("Request body are invalid", 400);
                result.ExceptionMessage = new SerializableError(context.ModelState);

                Log.Warning("{Middleware} Bad request, Body is invalided [Code={Code},Error={Message}]", "Model Filter", result.Code, result.ExceptionMessage);

                context.Result = new BadRequestObjectResult(result);
            }
        }
    }
}