using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.Models.FC;
using System.Linq;
//using Apv.AV.Services.Data.FC;
using Microsoft.EntityFrameworkCore;
using Apv.AV.Common;

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
            return _context.Versions.Where(a => a.platform == platform).FirstOrDefault();;
        }

        public ICollection<AppVersion> getAllAppVersions()
        {
            return _context.Versions.ToList();
        }

        public ICollection<CarModel> getCarModels(string countryCode, string companyId, string modelClassId, string carModelId)
        {
            return _context
                .CarModels
                .Include(c=>c.carModelClass)
                .ToList();
        }

        public ICollection<FinancialProduct> getFinancialProductsByCarModel(string countryCode, string companyId, string carModelId)
        {
            return _context.FinancialProducts.
                           Where(fp => 
                                 fp.carModels.
                                 Where(cm=>cm.carModel.carModelId==carModelId).Any()                                
                                ).ToList();
            
        }

    }
}