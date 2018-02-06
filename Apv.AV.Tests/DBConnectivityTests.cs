using System;
using Xunit;
using Apv.AV.Services.Data.FC;
using Microsoft.EntityFrameworkCore; 

namespace Apv.AV.Tests
{
    public class DBConnectivityTests
    {
        [Fact]
        public void ConnectToDB()
        {

            var optionsBuilder = new DbContextOptionsBuilder<ApvFCAppContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;User Id=sa;Password=p@ssw0rd; Initial Catalog=apvDB");

            using (var context = new ApvFCAppContext(optionsBuilder.Options))
            {
                context.Database.Migrate();
                context.EnsureSeedDataForContext();
                // do stuff
            }


            
        }
    }
}
