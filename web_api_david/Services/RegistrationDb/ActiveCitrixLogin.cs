using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class ActiveCitrixLogin
    {
        public int Id { get; set; }
        public string? VsouserName { get; set; }
        public DateTime? LastLogon { get; set; }
        public DateTime? Created { get; set; }
    }
}
