using System;
using System.Collections.Generic;


namespace Apv.AV.Services.DTO.FC
{
    public class CarModelClassDto
    {
        public string id { get; set; }
        public string countryCode { get; set; }
        public string companyId { get; set; }
        public string modelClassId { get; set; }
        public string modelClassCode { get; set; }
        public string modelClassBrand {get;set;}
        public string modelClassLabel { get; set; }
        public string modelClassLabelLoc { get; set; }
        public string modelClassTypeLabel { get; set; }
        public string modelClassTypeLabelLoc { get; set; }
        public List<CarModelClassImageDto> carModelClassImages {get;set;}
        public decimal order { get; set; }
        public bool published { get; set; }

    }
}