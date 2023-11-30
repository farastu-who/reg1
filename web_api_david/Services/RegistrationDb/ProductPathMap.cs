using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class ProductPathMap
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int ProductId { get; set; }
        public int PathId { get; set; }

        public virtual Path Path { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
