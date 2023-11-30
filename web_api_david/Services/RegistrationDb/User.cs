using System;
using System.Collections.Generic;

namespace web_api.Services.RegistrationDb
{
    public partial class User
    {
        public User()
        {
            Interaction = new HashSet<Interaction>();
            RegistrationLog = new HashSet<RegistrationLog>();
            UserEventMap = new HashSet<UserEventMap>();
            UserProductConfigurationTypeMap = new HashSet<UserProductConfigurationTypeMap>();
            UserProductMap = new HashSet<UserProductMap>();
            UserRemoteAccessEventMap = new HashSet<UserRemoteAccessEventMap>();
            UserRoleMap = new HashSet<UserRoleMap>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? CompanyId { get; set; }
        public string Salutation { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string FaxNumber { get; set; } = null!;
        public string? Title { get; set; }
        public string? Department { get; set; }
        public string? Note { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Guid? UnlockKey { get; set; }
        public bool? IsMainContact { get; set; }
        public bool? IsUserActive { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? UafupdateDate { get; set; }
        public string? UpdateSource { get; set; }
        public int? OldId { get; set; }
        public int? OldCompanyId { get; set; }
        public bool? IsAdmin { get; set; }
        public int? AddressId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string? Subscription { get; set; }
        public string? VsouserName { get; set; }
        public string? Sqllogin { get; set; }
        public string? Sqlpassword { get; set; }
        public bool RemoteAccess { get; set; }
        public bool ShipTo { get; set; }
        public string? ShipNotes { get; set; }
        public string? ContactEmail { get; set; }
        public bool MigrationSent { get; set; }
        public DateTime? MigrationStart { get; set; }
        public DateTime? MigrationComplete { get; set; }

        public virtual Address? Address { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ICollection<Interaction> Interaction { get; set; }
        public virtual ICollection<RegistrationLog> RegistrationLog { get; set; }
        public virtual ICollection<UserEventMap> UserEventMap { get; set; }
        public virtual ICollection<UserProductConfigurationTypeMap> UserProductConfigurationTypeMap { get; set; }
        public virtual ICollection<UserProductMap> UserProductMap { get; set; }
        public virtual ICollection<UserRemoteAccessEventMap> UserRemoteAccessEventMap { get; set; }
        public virtual ICollection<UserRoleMap> UserRoleMap { get; set; }
    }
}
