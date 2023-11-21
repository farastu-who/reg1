using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class InteractionInteractionNatureMap
    {
        public int Id { get; set; }
        public int InteractionId { get; set; }
        public int InteractionNatureId { get; set; }

        public virtual Interaction Interaction { get; set; } = null!;
        public virtual InteractionNature InteractionNature { get; set; } = null!;
    }
}
