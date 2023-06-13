using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace SwaggerLibrary;
public static class SwaggerConfig
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Swagger Library API",
                Description = "A sample API documentation using Swagger",
                Contact = new OpenApiContact
                {
                    Name = "Your Name",
                    Email = "your@email.com",
                    Url = new Uri("https://your-website.com")
                }
            });
        });
    }
}
