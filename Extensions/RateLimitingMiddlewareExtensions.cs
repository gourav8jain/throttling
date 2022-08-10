using throttling.Middlewares;

namespace throttling.Extensions
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RateLimitingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRateLimitingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RateLimitingMiddleware>();
        }
    }
}
