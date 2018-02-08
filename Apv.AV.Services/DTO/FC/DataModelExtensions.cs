using System;
using System.Linq;
using Apv.AV.Services.Data.Models.FC;


namespace Apv.AV.Services.DTO.FC
{
    public static class DataModelEntensions
    {
        /*
        public static CarModelDto ConvertModelDto(this CarModel source)
        {
            return new CarModelDto()
            {
                id = source.id,
                carModelClass = source.carModelClass.ConvertModelDto(),
                carModelId = source.carModelId,
                modelLabel = source.modelLabel,
                modelLabelLoc = source.modelLabelLoc,
                published = source.published,
                order = source.order,
                coverImage = source.coverImage,
                carPrices = source.carPrices.Select(a => a.ConvertModelDto()).ToList(),
                financialProducts =   source.financialProducts.Select(a=>a.ConvertModelDto()).ToList()
            };
        }
        */
        public static CarModelClassDto ConvertModelDto(this CarModelClass source)
        {
            return new CarModelClassDto()
            {
                id=source.id,
                countryCode = source.countryCode,
                modelClassId = source.modelClassId,
                modelClassCode =source.modelClassCode,
                modelClassBrand = source.modelClassBrand,
                modelClassLabel = source.modelClassLabel,
                modelClassLabelLoc = source.modelClassLabelLoc,
                modelClassTypeLabel = source.modelClassTypeLabel,
                modelClassTypeLabelLoc = source.modelClassTypeLabelLoc,
                carModelClassImages = source.carModelClassImages.Select((a=>a.ConvertModelDto())).ToList()
            };
        }

        public static CarPriceDto ConvertModelDto(this CarPrice source)
        {
            return new CarPriceDto() 
            { 
                id = source.id,
                companyId = source.companyId,
                price = source.price
            };
        }

        public static FinancialProductDto ConvertModelDto(this FinancialProduct source)
        {
            return new FinancialProductDto() 
            { 
                id = source.id,
                name = source.name,
                description = source.description
            };
        }

        public static CarModelClassImageDto ConvertModelDto(this CarModelClassImage source)
        {
            return new CarModelClassImageDto() 
            { 
                id = source.id,
                coverImage = source.coverImage,
                thumbnailImage = source.thumbnailImage,
                onlineImage = source.onlineImage,
                verticalImage = source.verticalImage            
            };
        }

    }
}
