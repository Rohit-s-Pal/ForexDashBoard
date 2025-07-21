namespace ForexAPI
{
    public class NoCacheHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public NoCacheHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Set no-cache headers early
            context.Response.Headers["Cache-Control"] = "no-store, no-cache, must-revalidate, max-age=0";
            context.Response.Headers["Pragma"] = "no-cache";
            context.Response.Headers["Expires"] = "-1";

            await _next(context); // Call next middleware/controller
        }
    }

}
