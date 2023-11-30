using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class VsouserActivity
    {
        public string UserName { get; set; } = null!;
        public DateTime? LastConfirmedActivity { get; set; }
    }
}
