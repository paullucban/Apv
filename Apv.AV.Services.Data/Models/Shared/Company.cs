using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Apv.AV.Services.Data.Models.Shared
{
    public class Company
    {
        [Key,MaxLength(10)]
        public string companyId { get; set; }

        [MaxLength(10)]
        public string companyCode { get; set; }

        [MaxLength(500)]
        public string companyName { get; set; }

        [MaxLength(500)]
        public string companyNameLoc { get; set; }

        [MaxLength(500)]
        public string companyLogo { get; set; }

        [MaxLength(20)]
        public string phone { get; set; }

        [MaxLength(20)]
        public string mobile { get; set; }

        [MaxLength(1000)]
        public string homePage { get; set; }

        [MaxLength(20)]
        public string fax { get; set; }

        [MaxLength(500)]
        public string email { get; set; }

        [MaxLength(10)]
        public string postalCode { get; set; }

        [MaxLength(10)]
        public string latitude { get; set; }

        [MaxLength(10)]
        public string longtitude { get; set; }

        [MaxLength(30)]
        public string createdBy { get; set; }

        public DateTime createdDt { get; set; }

        [MaxLength(30)]
        public string lastUpdatedBy { get; set; }

        public DateTime lastUpdatedDt { get; set; }

    }
}
