using System;
using Apv.AV.Services.Data.Models.FC;
using Apv.AV.Services.DTO.FC;
using Apv.AV.Services.DTO;
using System.Collections.Generic;

namespace Apv.AV.Services.FC
{
    public interface IApvFCServices
    {
        ICollection<AppVersion> getAllAppVersions();

        ApvAPIResponse<AppVersion> getAppVersion(string platform);

        ICollection<CarModelDto> getCarModels(string countryCode, string companyId, string modelClassId, string carModelId);
    }
}
