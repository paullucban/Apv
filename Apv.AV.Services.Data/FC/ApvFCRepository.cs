using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.Models.FC;
using System.Linq;
using Apv.AV.Services.Data.FC;
using Microsoft.EntityFrameworkCore;


namespace Apv.AV.Services.Data.FC
{
    public class ApvFCRepository : IApvFCRepository
    {

        ApvAppContext _context;

        public ApvFCRepository(ApvAppContext context)
        {
            _context = context;
        }

        public AppVersion getAppVersion(string platform)
        {
            return _context.Versions.Where(a => a.platform == platform).FirstOrDefault();
        }

        public ICollection<AppVersion> getAllAppVersions()
        {
            return _context.Versions.ToList();
        }
    }
}