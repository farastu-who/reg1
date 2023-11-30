using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class StateProvince
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? CountryId { get; set; }
        public bool? Visible { get; set; }

        public virtual Country? Country { get; set; }
    }
}
