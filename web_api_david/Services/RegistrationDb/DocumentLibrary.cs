using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class DocumentLibrary
    {
        public string Key { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Path { get; set; } = null!;
    }
}
