using System;

namespace Apv.AV.Services.Data.Models.FC
{
    public class CarModelFinancialProduct
    {
        public int id { get; set; }
        public FinancialProduct financialProduct { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDt { get; set; }
        public string lastUpdatedBy {get;set;}
        public DateTime lastUpdatedDt { get; set; }
    }
}