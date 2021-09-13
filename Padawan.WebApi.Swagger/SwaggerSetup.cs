using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace Padawan.WebApi.Swagger
{
    public static class SwaggerSetup
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection serviceDescriptors)
        {
            return serviceDescriptors.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API .NET Core",
                    Version = "v1",
                    Description = ".Net e Angular.",
                    Contact = new OpenApiContact
                    {
                        Name = "Wallace Jesus",
                        Email = "wallacev2@gmail.com"
                    }
                });
                string xmlPath = Path.Combine("Documentation", "api-doc.xml");
                opt.IncludeXmlComments(xmlPath);
            });
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseSwagger().UseSwaggerUI(c =>
            {
                c.RoutePrefix = "documentation";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");
            });
        }
    }
}
