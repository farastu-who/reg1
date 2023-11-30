using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class FinanceGiscodeCompanyId
    {
        public string FinanceGiscode { get; set; } = null!;
        public int CompanyId { get; set; }
        public string FinanceName { get; set; } = null!;
        public int Rowid { get; set; }
        public string? EntityCat { get; set; }
        public string? SubCat { get; set; }
        public string? Tier { get; set; }
    }
}
