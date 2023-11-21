using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class UserProductMap
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime InstallDate { get; set; }
        public bool IsProductActive { get; set; }
        public int GraceLoginsAllowed { get; set; }
        public string? UpdateSource { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
