using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class RegistrationLog
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public string? UpdateSource { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
