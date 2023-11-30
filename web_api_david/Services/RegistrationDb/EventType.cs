using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class EventType
    {
        public EventType()
        {
            Event = new HashSet<Event>();
            RemoteAccessEvent = new HashSet<RemoteAccessEvent>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<RemoteAccessEvent> RemoteAccessEvent { get; set; }
    }
}
