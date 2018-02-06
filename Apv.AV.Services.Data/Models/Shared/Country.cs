using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Apv.AV.Services.Data.Models.Shared
{
    public class Country
    {
        [Key,MinLength(2),MaxLength(3)]
        public string countryCode { get; set; }

        [MinLength(3), MaxLength(3)]
        public string countryName { get; set; }

        [MinLength(3), MaxLength(3)]
        public string currencySymbol { get; set; }

        [MaxLength(20)]
        public string dateFormat { get; set; }

        public int timeZone { get; set; }

        public int formatDisplayDecimalPlace { get; set; }

        [MaxLength(20)]
        public string roundingMethodForCalculation { get; set; }

        [MaxLength(30)]
        public string createdBy { get; set; }

        public DateTime createdDt { get; set; }

        [MaxLength(30)]
        public string lastUpdatedBy { get; set; }

        public DateTime lastUpdatedDt { get; set; }

    }
}
