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
            string logPath = "C:\\Logs\\WebApiErrorLog.txt";

            
            Directory.CreateDirectory(Path.GetDirectoryName(logPath)!);

            string error = $"[{DateTime.Now}] Exception: {context.Exception.Message}\nStackTrace: {context.Exception.StackTrace}\n\n";
            File.AppendAllText(logPath, error);

            context.Result = new ObjectResult("Something went wrong. Please try again later.")
            {
                StatusCode = 500
            };
        }
    }
}
