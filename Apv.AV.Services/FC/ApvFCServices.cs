using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.FC;
using Apv.AV.Services.Data.Models.FC;

namespace Apv.AV.Services.FC
{
    public class ApvFCServices:IApvFCServices
    {
        private IApvFCRepository _repo;

        public ApvFCServices(IApvFCRepository repo)
        {
            _repo = repo;
        }

        public ICollection<AppVersion> getAllAppVersions()
        {
            return _repo.GetAppVersions();
        }

        public AppVersion getAppVersion(string platform)
        {
            return _repo.GetAppVersion(platform);
        }
    }
}
