using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc.ApiExplorer; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using ParksApi.Models;

namespace ParksApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ParksApiContext>(opt =>
            opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
         
            services.AddControllers();
            services.AddApiVersioning(options => {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ApiVersionReader = ApiVersionReader.Combine(
                    new HeaderApiVersionReader("x-api-version"),
                    new MediaTypeApiVersionReader("x-api-version")
                );
                
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                { 
                    Title = "ParksApi - V1", 
                    Version = "v1",
                    Description = "An AspNetCore Web Api for information about parks.",
                    Contact = new OpenApiContact
                    {
                        Name = "Liam Campbell",
                        Url = new Uri("https://github.com/lcmpbll")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Mit License",
                        Url = new Uri("https://github.com/lcmpbll/ParksApi.Solution/blob/main/LICENSE")
                    } 
                });
                c.SwaggerDoc("v2", new OpenApiInfo
                { 
                    Title = "ParksApi - V2", 
                    Version = "v2",
                    Description = "An AspNetCore Web Api for information about parks.",
                    Contact = new OpenApiContact
                    {
                        Name = "Liam Campbell",
                        Url = new Uri("https://github.com/lcmpbll")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Mit License",
                        Url = new Uri("https://github.com/lcmpbll/ParksApi.Solution/blob/main/LICENSE")
                    }
                });
                // c.ResolveConflictingActions(apiDescription => api.Descriptions.First());
                c.DocInclusionPredicate((docName, apiDesc) => apiDesc.GroupName == docName);
                var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName));
            });
            
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
             app.UseSwagger();
             app.UseSwaggerUI(c => 
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    c.SwaggerEndpoint("swagger/v2/swagger.json", "v2");
                    c.RoutePrefix = string.Empty;
                    
                });
                
           
        }
    }
}
