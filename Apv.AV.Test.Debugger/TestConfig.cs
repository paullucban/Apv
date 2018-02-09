using System;
using Microsoft.Extensions.Configuration;
using Apv.AV.Services.Data;
using Microsoft.EntityFrameworkCore;

namespace Apv.AV.Test.Debugger
{
    public class TestConfig
    {
        public TestConfig()
        {
            
        }

        public static IConfiguration getConfig()
        {
            /*
            var builder = new ConfigurationBuilder()
                .SetBasePath(System.AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json",
            optional: true,
            reloadOnChange: true);

            return builder.Build();
            */
            return null;
        }

        public static ApvAppContext getDbContext()
        {
            var config = getConfig();
            var connectionString = "Data Source=localhost;User Id=sa;Password=p@ssw0rd; Initial Catalog=apvDB";//config.GetConnectionString("ApvConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApvAppContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new ApvAppContext(optionsBuilder.Options);
        }
    }
}
