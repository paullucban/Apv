using Apv.AV.Services.Data.Models.FC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apv.AV.Services.Data.FC
{
    public static class ApvFCDataExtension
    {
        public static void EnsureSeedDataForContext(this ApvFCAppContext context)
        {
            if (!context.Versions.Any())
            {
            // init seed data
                var versions = new List<AppVersion>()
                {
                    new AppVersion()
                    {
                        id = Guid.NewGuid().ToString(),
                        platform = "Android",
                        prevVersionCode = 1.0m,
                        newVersionCode = 2.0m,
                        forceUpgrade = true,
                        features = string.Empty,
                        downloadUrl ="www.google.com",
                        createdBy = "admin",
                        createdDt = DateTime.Now,
                        lastUpdatedBy = "admin",
                        lastUpdatedDt = DateTime.Now
                    },
                    new AppVersion()
                    {
                        id = Guid.NewGuid().ToString(),
                        platform = "iOS",
                        prevVersionCode = 1.0m,
                        newVersionCode = 2.0m,
                        forceUpgrade = true,
                        features = string.Empty,
                        downloadUrl ="www.google.com",
                        createdBy = "admin",
                        createdDt = DateTime.Now,
                        lastUpdatedBy = "admin",
                        lastUpdatedDt = DateTime.Now
                    }
                };
                context.Versions.AddRange(versions);            
            }
            context.SaveChanges();
        }
    }
}
