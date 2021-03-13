using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Payment.Helpers.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Payment.ErrorHandling
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IWebHostEnvironment env)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleException(httpContext, ex);
            }
        }

        private async Task HandleException(HttpContext httpContext, Exception exception)
        {
            bool success = false;

            string message = exception.Message == null ? "Internal Server Error" : exception.Message;
            int statusCode = (int)HttpStatusCode.InternalServerError;

                success = ((ApiException)exception).Success;
                message = ((ApiException)exception).Message;
                statusCode = ((ApiException)exception).Code;
            

            string response = Serializer.Serialize(new { success = success, message = message }, false);
            httpContext.Response.StatusCode = statusCode;
            httpContext.Response.ContentType = "application/json; charset=utf-8";

            await httpContext.Response.WriteAsync(response);
        }
    }
}
