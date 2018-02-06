using System;
using System.Collections.Generic;

namespace Apv.AV.Services.DTO.FC
{
    public class CarModelDto
    {
        public string id { get; set; }
        public CarModelClassDto carModelClass { get; set; }
        public string carModelId { get; set; }
        public string modelLabel { get; set; }
        public string modelLabelLoc { get; set; }
        public bool published { get; set; }
        public decimal order { get; set; }
        public string coverImage { get; set; }
        public List<CarPriceDto> carPrices { get; set; }
        public List<FinancialProductDto> financialProducts { get; set; }
    }
}
