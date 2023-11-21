using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class VsouserDeleted
    {
        public string UserName { get; set; } = null!;
        public DateTime DateDeleted { get; set; }
        public string? Note { get; set; }
    }
}
