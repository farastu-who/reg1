using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class SalesForceAccount
    {
        public int Id { get; set; }
        public string SalesForceId { get; set; } = null!;
        public int CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string? EntityCat { get; set; }
        public string? SubCat { get; set; }
        public string? Tier { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
