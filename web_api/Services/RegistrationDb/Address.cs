using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Address
    {
        public Address()
        {
            Company = new HashSet<Company>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string City { get; set; } = null!;
        public string StateProvince { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int? OldPersonId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
