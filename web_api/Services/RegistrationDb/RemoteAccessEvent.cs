using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class RemoteAccessEvent
    {
        public RemoteAccessEvent()
        {
            UserRemoteAccessEventMap = new HashSet<UserRemoteAccessEventMap>();
        }

        public int Id { get; set; }
        public int EventId { get; set; }
        public int EventTypeId { get; set; }
        public string MessageId { get; set; } = null!;
        public string Queue { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string? ProcessedBy { get; set; }

        public virtual Event Event { get; set; } = null!;
        public virtual EventType EventType { get; set; } = null!;
        public virtual ICollection<UserRemoteAccessEventMap> UserRemoteAccessEventMap { get; set; }
    }
}
