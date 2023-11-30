using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Country
    {
        public Country()
        {
            StateProvince = new HashSet<StateProvince>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Name { get; set; } = null!;
        public bool? Visible { get; set; }

        public virtual ICollection<StateProvince> StateProvince { get; set; }
    }
}
