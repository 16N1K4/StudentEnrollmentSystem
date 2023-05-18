namespace StudentEnrollmentAPI.Middleware
{
    public class AuthenticateAPIKey
    {
        private readonly RequestDelegate _next;
        private const string ApiKey = "ApiKey";
        // request object
        public AuthenticateAPIKey(RequestDelegate next)
        {
            _next = next;
        }

        // context container request response pipeline objects 
        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(ApiKey, out var extractedKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("No API key provided");
                return;
            }
            // validate the API Key
            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var key = appSettings.GetValue<string>(ApiKey);
            if (!key.Equals(extractedKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Access denied");
                return;
            }

            await _next(context);
        }
    }
}
