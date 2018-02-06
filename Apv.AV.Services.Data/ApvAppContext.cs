using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apv.AV.Services.Data.Models.FC;
using Apv.AV.Services.Data.Models.Shared;

namespace Apv.AV.Services.Data
{
    public class ApvAppContext:DbContext
    {
        public ApvAppContext(DbContextOptions<ApvAppContext> options)
        :base(options)
        {
            
        }

        public DbSet<AppVersion> Versions{get;set;}
        public DbSet<CarModelClass> CarModelClasses{get;set;}       
        public DbSet<CarModel> CarModels{get;set;}       
        public DbSet<FinancialProduct> FinancialProducts{get;set;}
        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CountryGlobalSetting> CountryGlobalSettings { get; set; }


    }
}