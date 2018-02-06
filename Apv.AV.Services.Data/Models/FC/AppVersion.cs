using System;

namespace Apv.AV.Services.Data.Models.FC
{
    public class AppVersion
    {
        public string id { get; set; }
        public string platform { get; set; }
        public decimal prevVersionCode {get;set;}
        public decimal newVersionCode { get; set; }
        public bool forceUpgrade { get; set; }
        public string features { get; set; }
        public string downloadUrl { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDt { get; set; }
        public string lastUpdatedBy {get;set;}
        public DateTime lastUpdatedDt { get; set; }

    }
}
