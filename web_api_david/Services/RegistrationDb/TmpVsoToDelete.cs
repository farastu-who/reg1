using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class TmpVsoToDelete
    {
        public string BadVsoaccount { get; set; } = null!;
        public string? EmailAddr { get; set; }
        public string? GoodVsoaccount { get; set; }
    }
}
