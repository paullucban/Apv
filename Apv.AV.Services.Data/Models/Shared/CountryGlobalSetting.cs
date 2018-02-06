using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Apv.AV.Services.Data.Models.Shared
{
    public class CountryGlobalSetting
    {
        [Key, MaxLength(36)]
        public string id { get; set; }

        public bool maintenanceMode { get; set; }

        public string maintenanceMessage { get; set; }

        public Country country { get; set; }
        public Company company { get; set; }


        [MaxLength(30)]
        public string createdBy { get; set; }

        public DateTime createdDt { get; set; }

        [MaxLength(30)]
        public string lastUpdatedBy { get; set; }

        public DateTime lastUpdatedDt { get; set; }
    }
}
