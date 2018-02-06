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

using Apv.AV.Services.Data.FC;
using Apv.AV.Services.FC;


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json.Serialization;
//using NLog.Extensions.Logging;
using Microsoft.EntityFrameworkCore; 

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
            services.AddDbContext<ApvFCAppContext>(o => o.UseSqlServer(connectionString));
            services.AddScoped<IApvFCRepository, ApvFCRepository>();
            services.AddTransient<IApvFCServices, ApvFCServices>();

        }

        // This methodc gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env, 
                              ApvFCAppContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //context.EnsureSeedDataForContext();
            app.UseStatusCodePages();
            app.UseMvc();
        }
    }
}
