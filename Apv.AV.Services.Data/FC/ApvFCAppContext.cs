using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apv.AV.Services.Data.Models.FC;

namespace Apv.AV.Services.Data.FC
{
    public class ApvFCAppContext:DbContext
    {
        public ApvFCAppContext(DbContextOptions<ApvFCAppContext> options)
        :base(options)
        {
            
        }

        public DbSet<AppVersion> Versions{get;set;}




    }
}