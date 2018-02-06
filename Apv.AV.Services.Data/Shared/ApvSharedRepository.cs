using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.Models.FC;
using System.Linq;
using Apv.AV.Services.Data.FC;
using Microsoft.EntityFrameworkCore;
using Apv.AV.Services.Data.Models.Shared;

namespace Apv.AV.Services.Data.Shared
{
    public class ApvSharedRepository : IApvSharedRepository
    {

        ApvAppContext _context;

        public ApvSharedRepository(ApvAppContext context)
        {
            _context = context;
        }

        public ICollection<CountryGlobalSetting> getCountryGlobalSettings()
        {
            return _context.CountryGlobalSettings.ToList();
        }

        public CountryGlobalSetting getCountryGlobalSetting(string countryCode)
        {
            return _context.CountryGlobalSettings.Where((a => a.country.countryCode == countryCode)).FirstOrDefault();
        }
    }
}