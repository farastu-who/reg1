using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class VsouserExtended
    {
        public int CompanyId { get; set; }
        public string UserName { get; set; } = null!;
        public string? Email { get; set; }
        public bool IsAdactive { get; set; }
    }
}
