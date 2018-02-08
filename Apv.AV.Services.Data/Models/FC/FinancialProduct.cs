
using System;
using System.Collections.Generic;
namespace Apv.AV.Services.Data.Models.FC
{
    public class FinancialProduct
    {
        public int id { get; set; }
        public string countryCode { get; set; }
        public string companyId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public virtual List<CarModelFinancialProduct> carModels { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDt { get; set; }
        public string lastUpdatedBy {get;set;}
        public DateTime lastUpdatedDt { get; set; }
    }
}
