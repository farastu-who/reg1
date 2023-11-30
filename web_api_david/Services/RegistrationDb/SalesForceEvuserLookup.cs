using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class SalesForceEvuserLookup
    {
        public string SalesForceContactId { get; set; } = null!;
        public int EvuserId { get; set; }
        public bool? SalesForceContactStatus { get; set; }
    }
}
