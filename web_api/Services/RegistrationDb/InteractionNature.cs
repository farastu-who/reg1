using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class InteractionNature
    {
        public InteractionNature()
        {
            InteractionInteractionNatureMap = new HashSet<InteractionInteractionNatureMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SortOrder { get; set; }

        public virtual ICollection<InteractionInteractionNatureMap> InteractionInteractionNatureMap { get; set; }
    }
}
