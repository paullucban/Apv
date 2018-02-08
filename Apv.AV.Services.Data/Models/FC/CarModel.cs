using System;
using System.Collections.Generic;

namespace Apv.AV.Services.Data.Models.FC
{
    public class CarModel
    {
        public string id { get; set; }
        public virtual CarModelClass carModelClass { get; set; }
        public string carModelId { get; set; }
        public string modelLabel { get; set; }
        public string modelLabelLoc { get; set; }
        public bool published {get;set;}
        public decimal order {get;set;}
        public string coverImage { get; set; }
        public virtual List<CarPrice> carPrices {get;set;}
        public string createdBy { get; set; }
        public DateTime createdDt { get; set; }
        public string lastUpdatedBy {get;set;}
        public DateTime lastUpdatedDt { get; set; }
    }
}
