using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.Models.Shared;

namespace Apv.AV.Services.Data.Shared
{
    public interface IApvSharedRepository
    {
        ICollection<CountryGlobalSetting> getCountryGlobalSettings();
        CountryGlobalSetting getCountryGlobalSetting(string countryCode);
    }
}
