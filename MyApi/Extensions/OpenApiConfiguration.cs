using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MyApi.Filters;

namespace MyApi.Extensions
{
    internal static class OpenApiConfiguration
    {
        public static IServiceCollection AddCustomOpenApi(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API Swagger v1", Version = "v1" });
                c.SwaggerDoc("v2", new OpenApiInfo { Title = "My API Swagger v2" , Version = "v2" });

                c.IncludeXmlComments(Path.Combine(System.AppContext.BaseDirectory, "MyApi.xml"),true);
                
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.OperationFilter<SwaggerRemoveVersionFilter>();
                c.DocumentFilter<SwaggerReplaceVersionFilter>();
            });

            return services;
        }

        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API Swagger v1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "My API Swagger v2");
            });
        }
    }
}
