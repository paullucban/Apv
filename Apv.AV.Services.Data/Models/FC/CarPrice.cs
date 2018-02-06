
using System;

namespace Apv.AV.Services.Data.Models.FC
{
    public class CarPrice
    {
        public int id { get; set; }
        public CarModel carModel { get; set; }
        public string companyId { get; set; }
        public decimal price { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDt { get; set; }
        public string lastUpdatedBy {get;set;}
        public DateTime lastUpdatedDt { get; set; }
    }
}
