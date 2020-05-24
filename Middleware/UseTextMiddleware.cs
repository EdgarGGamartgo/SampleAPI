using Microsoft.AspNetCore.Builder;

namespace SampleAPI
{
    public static class RequestTextMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestText(
            this IApplicationBuilder builder)
        {
         //   return builder.UseMiddleware<TextMiddleware>();
              //  return builder.Map("/test/path", _=>       // Conditional Middleware
                //        _.UseMiddleware<TextMiddleware>());
            // Conditionl predicate middleware
            return builder.MapWhen(context => context.Request.IsHttps,
                _=> _.UseMiddleware<TextMiddleware>()
            );

        }
    }
}