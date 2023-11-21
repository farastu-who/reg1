using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class Company
    {
        public Company()
        {
            CompanyEventMap = new HashSet<CompanyEventMap>();
            CompanyProductMap = new HashSet<CompanyProductMap>();
            Interaction = new HashSet<Interaction>();
            MailQueue = new HashSet<MailQueue>();
            User = new HashSet<User>();
            UserRemoteAccessEventMap = new HashSet<UserRemoteAccessEventMap>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Name { get; set; } = null!;
        public Guid? Code { get; set; }
        public int? EvholdingCorpId { get; set; }
        public int? SqlcalCount { get; set; }
        public string? Note { get; set; }
        public string? UpdateSource { get; set; }
        public bool? IsActive { get; set; }
        public int? OldId { get; set; }
        public int? OldMainContactId { get; set; }
        public int? AddressId { get; set; }
        public bool RemoteAccess { get; set; }
        public string? Prefix { get; set; }
        public bool AzureMigrated { get; set; }
        public bool VsoapprovalNeeded { get; set; }
        public bool IsTrial { get; set; }
        public DateTime? TrialExpiration { get; set; }

        public virtual Address? Address { get; set; }
        public virtual ICollection<CompanyEventMap> CompanyEventMap { get; set; }
        public virtual ICollection<CompanyProductMap> CompanyProductMap { get; set; }
        public virtual ICollection<Interaction> Interaction { get; set; }
        public virtual ICollection<MailQueue> MailQueue { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserRemoteAccessEventMap> UserRemoteAccessEventMap { get; set; }
    }
}
