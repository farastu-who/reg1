using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class AzureLogStatsUpdate
    {
        public string Databasename { get; set; } = null!;
        public DateTime? Statsbegin { get; set; }
        public DateTime? Statsend { get; set; }
    }
}
