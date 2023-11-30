using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Vsouser
    {
        public string CompanyName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? EmailAddr { get; set; }
        public string Password { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public int? CompanyId { get; set; }
        public int? OldCompanyId { get; set; }
    }
}
