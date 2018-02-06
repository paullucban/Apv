using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.Shared;
using Apv.AV.Services.Data.Models.Shared;
using Apv.AV.Services.DTO;

namespace Apv.AV.Services.Shared
{
    public class ApvSharedServices:IApvSharedServices
    {
        private IApvSharedRepository _repo;
        public ApvSharedServices(IApvSharedRepository repo)
        {
            _repo = repo;
        }

        public CountryGlobalSetting getCountryGlobalSetting(string countryCode)
        {
            return _repo.getCountryGlobalSetting(countryCode);
        }

        public ICollection<CountryGlobalSetting> getCountryGlobalSettings()
        {
            return _repo.getCountryGlobalSettings();
        }
    }
}
