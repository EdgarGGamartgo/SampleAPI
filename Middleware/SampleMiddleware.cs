using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System;

namespace SampleAPI


{
  public class SampleMiddleware
  {
    private readonly RequestDelegate _next;

      public SampleMiddleware(RequestDelegate next)
      {
        _next = next;
      }

        public async Task InvokeAsync(HttpContext context)
        {
              //  DO STUFF
              Console.WriteLine("Standard Numeric Format Specifiers");
              //  Call the next delegate/middleware in the pipeline
              await _next(context); 
        }
  }

       
}