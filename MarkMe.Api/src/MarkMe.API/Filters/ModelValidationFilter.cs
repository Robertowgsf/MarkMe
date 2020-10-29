using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;

namespace TesteTodoList.API.Filters
{
    public class ModelValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context) { }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var validationErrors = new List<dynamic>();

                foreach (var property in context.ModelState.Keys)
                {
                    var propertyName = char.ToLowerInvariant(property[0]) + property.Substring(1);
                    var errors = context.ModelState[property].Errors.Select(property => property.ErrorMessage);
                    validationErrors.Add(new { PropertyName = propertyName, Errors = errors });
                }

                context.Result = new BadRequestObjectResult(validationErrors);
            }
        }
    }
}
