using System;
using System.IO;
using Apv.AV.Services.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Apv.AV.Web
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApvAppContext>
    {
        public ApvAppContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApvAppContext>();
            var connectionString = configuration.GetConnectionString("ApvConnection");
            builder.UseSqlServer(connectionString);
            return new ApvAppContext(builder.Options);
        }


    }
}
