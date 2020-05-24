using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;
using System;

namespace SampleAPI
{
    public class TextMiddleware
    {
        private readonly RequestDelegate _next;

        public TextMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IPaymentService paymentService)
        {
            var cultureQuery = context.Request.Query["culture"];
            if (!string.IsNullOrWhiteSpace(cultureQuery))
            {
                var culture = new CultureInfo(cultureQuery);

                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;

            }
            Console.WriteLine(paymentService.GetMessage());
            Console.WriteLine("TextMiddleware in action!");
            // Call the next delegate/middleware in the pipeline
            await _next(context);
        }
    }
}