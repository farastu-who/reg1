using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class TmpContactChange
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int OldContactId { get; set; }
        public string OldContactName { get; set; } = null!;
        public int? NewContactId { get; set; }
    }
}
