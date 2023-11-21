using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Interaction
    {
        public Interaction()
        {
            InteractionInteractionNatureMap = new HashSet<InteractionInteractionNatureMap>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int? UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? Description { get; set; }
        public int InteractionTypeId { get; set; }
        public int InteractionStatusId { get; set; }
        public int InteractionDurationId { get; set; }
        public string? Notes { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual InteractionDuration InteractionDuration { get; set; } = null!;
        public virtual InteractionStatus InteractionStatus { get; set; } = null!;
        public virtual InteractionType InteractionType { get; set; } = null!;
        public virtual User? User { get; set; }
        public virtual ICollection<InteractionInteractionNatureMap> InteractionInteractionNatureMap { get; set; }
    }
}
