using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class InteractionDuration
    {
        public InteractionDuration()
        {
            Interaction = new HashSet<Interaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SortOrder { get; set; }

        public virtual ICollection<Interaction> Interaction { get; set; }
    }
}
