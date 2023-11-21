using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class CompanyProductMap
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LicenseCount { get; set; }
        public string? UpdateSource { get; set; }
        public bool IsSuspended { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
