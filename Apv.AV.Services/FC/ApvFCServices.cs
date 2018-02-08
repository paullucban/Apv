using System;
using System.Collections.Generic;
using Apv.AV.Services.Data.FC;
using Apv.AV.Services.Data.Models.FC;
using Apv.AV.Services.DTO.FC;
using Apv.AV.Services.DTO;
using System.Linq;

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
            return _repo.getAllAppVersions();
        }

        public ApvAPIResponse<AppVersion> getAppVersion(string platform)
        {
             return new ApvAPIResponse<AppVersion>(0, "", _repo.getAppVersion(platform));
        }

        public ICollection<CarModelDto> getCarModels(string countryCode, string companyId, string modelClassId, string carModelId)
        {
            return _repo.getCarModels(countryCode, companyId, modelClassId, carModelId).
                        Select(cm => new CarModelDto()
                        {
                            id = cm.id,
                            carModelClass = cm.carModelClass.ConvertModelDto(),
                            carModelId = cm.carModelId,
                            modelLabel = cm.modelLabel,
                            modelLabelLoc = cm.modelLabelLoc,
                            published = cm.published,
                            order = cm.order,
                            coverImage = cm.coverImage,
                            carPrices = cm.carPrices.Select(a => a.ConvertModelDto()).ToList(),
                            financialProducts = _repo.getFinancialProductsByCarModel(countryCode, companyId, cm.carModelId).
                                                            Select(a => a.ConvertModelDto()).ToList()
                        }).ToList();

        }

    }
}
