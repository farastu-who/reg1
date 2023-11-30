using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class SqlinfoEventMap
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int SqlinfoId { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; } = null!;
        public virtual Sqlinfo Sqlinfo { get; set; } = null!;
    }
}
