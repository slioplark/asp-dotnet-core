using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace AspDotNetCore.API.Middlewares
{
    /// <summary>
    /// Swagger Middleware
    /// </summary>
    public static class SwaggerMiddleware
    {
        /// <summary>
        /// Add Swagger
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static void AddSwaggerMiddleware(this IServiceCollection services)
        {
            var xmlFile = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "AspDotNetCore.API.xml");
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "RESTful API",
                    Version = "1.0.0",
                    Description = "This is ASP.NET Core RESTful API Sample.",
                });

                c.IncludeXmlComments(xmlFile);
            });
        }

        /// <summary>
        /// Use Swagger
        /// </summary>
        /// <param name="app"></param>
        public static void UseSwaggerMiddleware(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RESTful API v1");
            });
        }
    }
}
