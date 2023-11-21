using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class MailQueue
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string To { get; set; } = null!;
        public string? Cc { get; set; }
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string? MessageFile { get; set; }
        public string? Attachments { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
