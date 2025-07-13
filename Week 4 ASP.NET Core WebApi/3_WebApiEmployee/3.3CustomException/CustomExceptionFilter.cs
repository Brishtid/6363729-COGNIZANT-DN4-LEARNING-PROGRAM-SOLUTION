
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
            // Get exception message
            var message = $"[{DateTime.Now}] Exception: {context.Exception.Message}\nStackTrace: {context.Exception.StackTrace}\n";

            // Create logs folder if not exists
            var logDir = Path.Combine(Directory.GetCurrentDirectory(), "logs");
            Directory.CreateDirectory(logDir);

            // Write to errors.txt
            var logFilePath = Path.Combine(logDir, "errors.txt");
            File.AppendAllText(logFilePath, message);

            // Set HTTP 500 response
            context.Result = new ObjectResult("Something went wrong on the server.")
            {
                StatusCode = 500
            };
        }
    }
}
