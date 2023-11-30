using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Role
    {
        public Role()
        {
            UserRoleMap = new HashSet<UserRoleMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<UserRoleMap> UserRoleMap { get; set; }
    }
}
