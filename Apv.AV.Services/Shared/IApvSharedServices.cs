using System;
using Apv.AV.Services.Data.Models.Shared;
using System.Collections.Generic;

namespace Apv.AV.Services.Shared
{
    public interface IApvSharedServices
    {
        ICollection<CountryGlobalSetting> getCountryGlobalSettings();
        CountryGlobalSetting getCountryGlobalSetting(string countryCode);

    }
}
