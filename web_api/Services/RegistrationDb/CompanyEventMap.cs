using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class CompanyEventMap
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int EventId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Event Event { get; set; } = null!;
    }
}
