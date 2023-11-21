using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Event
    {
        public Event()
        {
            CompanyEventMap = new HashSet<CompanyEventMap>();
            RemoteAccessEvent = new HashSet<RemoteAccessEvent>();
            SqlinfoEventMap = new HashSet<SqlinfoEventMap>();
            UserEventMap = new HashSet<UserEventMap>();
        }

        public int Id { get; set; }
        public int EventTypeId { get; set; }
        public string? Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Source { get; set; }
        public string? Parameters { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual EventType EventType { get; set; } = null!;
        public virtual ICollection<CompanyEventMap> CompanyEventMap { get; set; }
        public virtual ICollection<RemoteAccessEvent> RemoteAccessEvent { get; set; }
        public virtual ICollection<SqlinfoEventMap> SqlinfoEventMap { get; set; }
        public virtual ICollection<UserEventMap> UserEventMap { get; set; }
    }
}
