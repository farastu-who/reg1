using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class UpdateFilesStaging
    {
        public Guid Id { get; set; }
        public string ClientLocation { get; set; } = null!;
        public string Database { get; set; } = null!;
        public int Version { get; set; }
        public DateTime UpdateDate { get; set; }
        public long Size { get; set; }
        public string Md5 { get; set; } = null!;
    }
}
