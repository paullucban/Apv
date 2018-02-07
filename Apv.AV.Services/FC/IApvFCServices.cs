﻿using System;
using Apv.AV.Services.Data.Models.FC;
using Apv.AV.Services.DTO.FC;
using System.Collections.Generic;

namespace Apv.AV.Services.FC
{
    public interface IApvFCServices
    {
        ICollection<AppVersion> getAllAppVersions();

        AppVersion getAppVersion(string platform);

        ICollection<CarModelDto> getCarModels(string countryCode, string companyId, string modelClassId, string carModelId);
    }
}
