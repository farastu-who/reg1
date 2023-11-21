using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class UserProductConfigurationTypeMap
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductConfigurationTypeId { get; set; }

        public virtual ProductConfigurationType ProductConfigurationType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
