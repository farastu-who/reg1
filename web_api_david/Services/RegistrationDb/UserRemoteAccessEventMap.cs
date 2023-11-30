using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class UserRemoteAccessEventMap
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int RemoteAccessEventId { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual RemoteAccessEvent RemoteAccessEvent { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
