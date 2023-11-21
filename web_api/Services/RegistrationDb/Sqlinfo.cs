using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Sqlinfo
    {
        public Sqlinfo()
        {
            SqlinfoEventMap = new HashSet<SqlinfoEventMap>();
        }

        public int Id { get; set; }
        public string? SqlinstanceName { get; set; }
        public string? Sqlversion { get; set; }
        public bool IsProvidedLicense { get; set; }
        public string? Notes { get; set; }

        public virtual ICollection<SqlinfoEventMap> SqlinfoEventMap { get; set; }
    }
}
