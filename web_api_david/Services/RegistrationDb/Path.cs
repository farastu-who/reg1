using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Path
    {
        public Path()
        {
            ProductPathMap = new HashSet<ProductPathMap>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Path1 { get; set; } = null!;
        public string? Page { get; set; }

        public virtual ICollection<ProductPathMap> ProductPathMap { get; set; }
    }
}
