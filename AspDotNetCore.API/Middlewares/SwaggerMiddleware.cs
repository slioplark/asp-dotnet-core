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
        /// Add SwaggerGen
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static void AddSwaggerGen(this IServiceCollection services)
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
        /// <returns></returns>
        public static void UseSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger(c => { });
        }

        /// <summary>
        /// Use SwaggerUI
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RESTful API v1");
            });
        }
    }
}
