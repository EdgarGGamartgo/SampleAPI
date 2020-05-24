 using Microsoft.AspNetCore.Builder;


 namespace SampleAPI
{
public static class SampleMiddlewareExtensions
        {
            public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder builder)
            {
                return builder.UseMiddleware<SampleMiddleware>();
            }
        }
}
 