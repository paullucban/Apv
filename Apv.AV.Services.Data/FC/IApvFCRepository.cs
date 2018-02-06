using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.Models.FC;

namespace Apv.AV.Services.Data.FC
{
    public interface IApvFCRepository
    {
        ICollection<AppVersion> getAllAppVersions();
        AppVersion getAppVersion(string platform);
    }
}
