using System;
using System.Linq;
using Xunit;
using Apv.AV.Services.Data;
using Microsoft.EntityFrameworkCore; 

namespace Apv.AV.Tests
{
    public class DBConnectivityTests : IDisposable

    {
        private ApvAppContext context;

        public DBConnectivityTests()
        {
            context = TestConfig.getDbContext();
        }
        
        [Fact]
        public void ConnectToDB()
        {
            
               context.Database.Migrate();
               context.EnsureSeedDataForContext();
               var lst = context.Versions.Where((a=>a.platform.ToLower()=="ios"));
               Assert.Equal<int>(1, lst.Count());                       
        }


        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }
    }
}
