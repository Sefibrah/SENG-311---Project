using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

public class CustomFilter : IActionFilter, IExceptionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Validation logic for Employee class
        if (context.ActionArguments.TryGetValue("employee", out var employeeObject) && employeeObject is Employee employee)
        {
            // Perform validation and add model errors if necessary
            if (string.IsNullOrEmpty(employee.Name))
            {
                context.ModelState.AddModelError("employee.Name", "Name is required.");
            }

            // Add more validation logic as needed
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Action execution logic
    }

    public void OnException(ExceptionContext context)
    {
        // Exception handling logic
        context.Result = new ContentResult
        {
            StatusCode = 500,
            Content = "An unexpected error occurred. Please try again later."
        };
        context.ExceptionHandled = true;
    }
}
