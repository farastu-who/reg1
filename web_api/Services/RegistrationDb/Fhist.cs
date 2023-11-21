using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Fhist
    {
        public string? ProdGrouping { get; set; }
        public string? Product { get; set; }
        public string? PcRevType { get; set; }
        public string CustomerGis { get; set; } = null!;
        public int EvCompanyId { get; set; }
        public string? SalesSupportOrder { get; set; }
        public int? Year { get; set; }
        public string? Month { get; set; }
        public string? YearMonth { get; set; }
        public double? MonthlyRevenueUsd { get; set; }
    }
}
