using System;
using System.Linq;
using Xunit;
using Apv.AV.Services.Data;
using Microsoft.EntityFrameworkCore; 

namespace Apv.AV.Tests
{
    public class DBConnectivityTests

    {
        public DBConnectivityTests()
        {
            
        }
        
        [Fact]
        public void ConnectToDB()
        {

            var optionsBuilder = new DbContextOptionsBuilder<ApvAppContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;User Id=sa;Password=p@ssw0rd; Initial Catalog=apvDB");

            using (var context = new ApvAppContext(optionsBuilder.Options))
            {
                context.Database.Migrate();
                context.EnsureSeedDataForContext();
                var lst = context.Versions.ToList();
                Console.Write(lst.Count.ToString());
                // do stuff
            }                      
        }
    }
}
