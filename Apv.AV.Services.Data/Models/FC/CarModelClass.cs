using System;
using System.Collections.Generic;


namespace Apv.AV.Services.Data.Models.FC
{
    public class CarModelClass
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
        public List<CarModelClassImage> CarModelClassImages {get;set;}
        public decimal order { get; set; }
        public bool published { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDt { get; set; }
        public string lastUpdatedBy {get;set;}
        public DateTime lastUpdatedDt { get; set; }

    }
}