using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Product
    {
        public Product()
        {
            CompanyProductMap = new HashSet<CompanyProductMap>();
            ProductPathMap = new HashSet<ProductPathMap>();
            UserProductMap = new HashSet<UserProductMap>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Name { get; set; } = null!;
        public string? CurrentVersion { get; set; }
        public string? CommonDataLocation { get; set; }
        public string? ProductDataLocation { get; set; }
        public string? UpdateSource { get; set; }
        public int? OldId { get; set; }
        public bool IsInternal { get; set; }

        public virtual ICollection<CompanyProductMap> CompanyProductMap { get; set; }
        public virtual ICollection<ProductPathMap> ProductPathMap { get; set; }
        public virtual ICollection<UserProductMap> UserProductMap { get; set; }
    }
}
