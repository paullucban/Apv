using System;

namespace Apv.AV.Services.Data.Models.FC
{
    public class CarModelClassImage
    {
        public int id { get; set; }
        public string coverImage { get; set; }
        public string thumbnailImage { get; set; }
        public string verticalImage { get; set; }
        public string onlineImage { get; set; }        
        public CarModelClass CarModelClass {get;set;}
        public string createdBy { get; set; }
        public DateTime createdDt { get; set; }
        public string lastUpdatedBy {get;set;}
        public DateTime lastUpdatedDt { get; set; }
    }
}