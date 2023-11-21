using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class ProductConfigurationType
    {
        public ProductConfigurationType()
        {
            UserProductConfigurationTypeMap = new HashSet<UserProductConfigurationTypeMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SortOrder { get; set; }

        public virtual ICollection<UserProductConfigurationTypeMap> UserProductConfigurationTypeMap { get; set; }
    }
}
