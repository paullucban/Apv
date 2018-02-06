using System;
using System.IO;
using Apv.AV.Services.Data.FC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Apv.AV.Web
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApvFCAppContext>
    {
        public ApvFCAppContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApvFCAppContext>();
            var connectionString = configuration.GetConnectionString("ApvConnection");
            builder.UseSqlServer(connectionString);
            return new ApvFCAppContext(builder.Options);
        }


    }
}
