using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace _3_WebApiCrud.Filter
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var errorMessage = $"Exception: {exception.Message}\nStack Trace: {exception.StackTrace}";

            // Write to file (adjust path as needed)
            File.AppendAllText("logs/errors.txt", errorMessage + "\n\n");

            context.Result = new ObjectResult("An internal error occurred. Please try again later.")
            {
                StatusCode = 500
            };
        }
    }
}
