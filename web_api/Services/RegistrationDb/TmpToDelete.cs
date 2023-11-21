using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class TmpToDelete
    {
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string Company { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? LastValidation { get; set; }
        public string? Vsouser { get; set; }
    }
}
