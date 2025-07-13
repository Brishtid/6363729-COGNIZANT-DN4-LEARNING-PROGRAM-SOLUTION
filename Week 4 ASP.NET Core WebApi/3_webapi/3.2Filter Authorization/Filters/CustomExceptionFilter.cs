using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace _2_WebApiEmployee.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string logMessage = $"[{DateTime.Now}] Exception: {context.Exception.Message}\nStackTrace: {context.Exception.StackTrace}\n\n";

            
            File.AppendAllText("C:\\Logs\\WebApiErrorLog.txt", logMessage);

            context.Result = new ObjectResult("Something went wrong.")
            {
                StatusCode = 500
            };
        }
    }
}
