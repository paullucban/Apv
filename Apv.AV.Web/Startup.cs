using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Apv.AV.Services.Data;
using Apv.AV.Services.Data.FC;
using Apv.AV.Services.Data.Shared;
using Apv.AV.Services.FC;
using Apv.AV.Services.Shared;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json.Serialization;
//using NLog.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using Swashbuckle.AspNetCore.Swagger;

namespace Apv.AV.Web
{
    public class Startup
    {
        public static IConfiguration Configuration { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;         
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new Info { Title = "Auto-vantage APIs", Version = "v1" });
                });
            services.AddMvc()
                .AddMvcOptions(o => o.OutputFormatters.Add(
                    new XmlDataContractSerializerOutputFormatter()));
            //.AddJsonOptions(o => {
            //    if (o.SerializerSettings.ContractResolver != null)
            //    {
            //        var castedResolver = o.SerializerSettings.ContractResolver
            //            as DefaultContractResolver;
            //        castedResolver.NamingStrategy = null;
            //    }
            //});

            var connectionString = Startup.Configuration["connectionStrings:ApvConnection"];
            services.AddDbContext<ApvAppContext>(o => o.UseSqlServer(connectionString));

            services.AddScoped<IApvFCRepository, ApvFCRepository>();
            services.AddScoped<IApvSharedRepository, ApvSharedRepository>();

            services.AddTransient<IApvFCServices, ApvFCServices>();
            services.AddTransient<IApvSharedServices, ApvSharedServices>();

        }

        // This methodc gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env, 
                              ApvAppContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStatusCodePages();
            app.UseCors(builder =>
                builder.WithOrigins("*"));
                // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
              
            });
            app.UseMvc();
        }
    }
}
