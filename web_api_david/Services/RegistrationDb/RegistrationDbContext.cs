using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace web_api.Services.RegistrationDb
{
    public partial class RegistrationDbContext : DbContext
    {

        public RegistrationDbContext()
        {
        }

        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveAdusers> ActiveAdusers { get; set; } = null!;
        public virtual DbSet<ActiveCitrixLogin> ActiveCitrixLogin { get; set; } = null!;
        public virtual DbSet<AdUsers> AdUsers { get; set; } = null!;
        public virtual DbSet<Address> Address { get; set; } = null!;
        public virtual DbSet<AzureLogStatsUpdate> AzureLogStatsUpdate { get; set; } = null!;
        public virtual DbSet<Company> Company { get; set; } = null!;
        public virtual DbSet<CompanyEventMap> CompanyEventMap { get; set; } = null!;
        public virtual DbSet<CompanyProductMap> CompanyProductMap { get; set; } = null!;
        public virtual DbSet<Country> Country { get; set; } = null!;
        public virtual DbSet<DocumentLibrary> DocumentLibrary { get; set; } = null!;
        public virtual DbSet<Event> Event { get; set; } = null!;
        public virtual DbSet<EventType> EventType { get; set; } = null!;
        public virtual DbSet<Fhist> Fhist { get; set; } = null!;
        public virtual DbSet<FinanceGiscodeCompanyId> FinanceGiscodeCompanyId { get; set; } = null!;
        public virtual DbSet<Interaction> Interaction { get; set; } = null!;
        public virtual DbSet<InteractionDuration> InteractionDuration { get; set; } = null!;
        public virtual DbSet<InteractionInteractionNatureMap> InteractionInteractionNatureMap { get; set; } = null!;
        public virtual DbSet<InteractionNature> InteractionNature { get; set; } = null!;
        public virtual DbSet<InteractionStatus> InteractionStatus { get; set; } = null!;
        public virtual DbSet<InteractionType> InteractionType { get; set; } = null!;
        public virtual DbSet<MailQueue> MailQueue { get; set; } = null!;
        public virtual DbSet<Orm> Orm { get; set; } = null!;
        public virtual DbSet<Path> Path { get; set; } = null!;
        public virtual DbSet<Product> Product { get; set; } = null!;
        public virtual DbSet<ProductConfigurationType> ProductConfigurationType { get; set; } = null!;
        public virtual DbSet<ProductPathMap> ProductPathMap { get; set; } = null!;
        public virtual DbSet<RegistrationLog> RegistrationLog { get; set; } = null!;
        public virtual DbSet<RemoteAccessEvent> RemoteAccessEvent { get; set; } = null!;
        public virtual DbSet<Role> Role { get; set; } = null!;
        public virtual DbSet<SalesForceAccount> SalesForceAccount { get; set; } = null!;
        public virtual DbSet<SalesForceEvuserLookup> SalesForceEvuserLookup { get; set; } = null!;
        public virtual DbSet<Sqlinfo> Sqlinfo { get; set; } = null!;
        public virtual DbSet<SqlinfoEventMap> SqlinfoEventMap { get; set; } = null!;
        public virtual DbSet<StateProvince> StateProvince { get; set; } = null!;
        public virtual DbSet<TmpContactChange> TmpContactChange { get; set; } = null!;
        public virtual DbSet<TmpToDelete> TmpToDelete { get; set; } = null!;
        public virtual DbSet<TmpVsoToDelete> TmpVsoToDelete { get; set; } = null!;
        public virtual DbSet<TmpVsodir> TmpVsodir { get; set; } = null!;
        public virtual DbSet<TmpVsoserverlist> TmpVsoserverlist { get; set; } = null!;
        public virtual DbSet<TmpVsouserActivity> TmpVsouserActivity { get; set; } = null!;
        public virtual DbSet<UpdateFiles> UpdateFiles { get; set; } = null!;
        public virtual DbSet<UpdateFilesStaging> UpdateFilesStaging { get; set; } = null!;
        public virtual DbSet<User> User { get; set; } = null!;
        public virtual DbSet<UserEventMap> UserEventMap { get; set; } = null!;
        public virtual DbSet<UserProductConfigurationTypeMap> UserProductConfigurationTypeMap { get; set; } = null!;
        public virtual DbSet<UserProductMap> UserProductMap { get; set; } = null!;
        public virtual DbSet<UserRemoteAccessEventMap> UserRemoteAccessEventMap { get; set; } = null!;
        public virtual DbSet<UserRoleMap> UserRoleMap { get; set; } = null!;
        public virtual DbSet<Vsouser> Vsouser { get; set; } = null!;
        public virtual DbSet<VsouserActivity> VsouserActivity { get; set; } = null!;
        public virtual DbSet<VsouserDeleted> VsouserDeleted { get; set; } = null!;
        public virtual DbSet<VsouserExtended> VsouserExtended { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveAdusers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActiveADUsers");

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .HasColumnName("Column 0");

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .HasColumnName("Column 1");

                entity.Property(e => e.Column2)
                    .HasMaxLength(50)
                    .HasColumnName("Column 2");

                entity.Property(e => e.Column3)
                    .HasMaxLength(50)
                    .HasColumnName("Column 3");
            });

            modelBuilder.Entity<ActiveCitrixLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Active_Citrix_Login");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastLogon).HasColumnType("datetime");

                entity.Property(e => e.VsouserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VSOUserName");
            });

            modelBuilder.Entity<AdUsers>(entity =>
            {
                entity.ToTable("AD_Users");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aduser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADUser");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.OldPersonId).HasColumnName("OldPersonID");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AzureLogStatsUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Azure_LogStatsUpdate");

                entity.Property(e => e.Databasename)
                    .HasMaxLength(128)
                    .HasColumnName("databasename");

                entity.Property(e => e.Statsbegin)
                    .HasColumnType("datetime")
                    .HasColumnName("statsbegin");

                entity.Property(e => e.Statsend)
                    .HasColumnType("datetime")
                    .HasColumnName("statsend");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EvholdingCorpId).HasColumnName("EVHoldingCorpID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.OldMainContactId).HasColumnName("OldMainContactID");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SqlcalCount).HasColumnName("SQLCalCount");

                entity.Property(e => e.TrialExpiration).HasColumnType("datetime");

                entity.Property(e => e.UpdateSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VsoapprovalNeeded).HasColumnName("VSOApprovalNeeded");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Company_Address");
            });

            modelBuilder.Entity<CompanyEventMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyEventMap)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyEventMap_Company");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.CompanyEventMap)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyEventMap_Event");
            });

            modelBuilder.Entity<CompanyProductMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyProductMap)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyProductMap_Company");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CompanyProductMap)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyProductMap_Product");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DocumentLibrary>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasIndex(e => e.EventTypeId, "nci_wi_Event_71826ACCED920A7C54F7CA1A81E4EC03");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.Parameters)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.EventType)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.EventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_EventType");
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fhist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FHist");

                entity.Property(e => e.CustomerGis)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Customer (GIS)");

                entity.Property(e => e.EvCompanyId).HasColumnName("EV Company ID");

                entity.Property(e => e.Month)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyRevenueUsd).HasColumnName("Monthly Revenue (USD)");

                entity.Property(e => e.PcRevType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PC: RevType");

                entity.Property(e => e.ProdGrouping)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Prod_Grouping");

                entity.Property(e => e.Product)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SalesSupportOrder)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sales Support Order");

                entity.Property(e => e.YearMonth)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Year/Month");
            });

            modelBuilder.Entity<FinanceGiscodeCompanyId>(entity =>
            {
                entity.HasKey(e => e.FinanceGiscode);

                entity.ToTable("FinanceGIScodeCompanyID");

                entity.Property(e => e.FinanceGiscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FinanceGISCODE");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EntityCat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWID");

                entity.Property(e => e.SubCat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Interaction>(entity =>
            {
                entity.HasIndex(e => e.UserId, "nci_wi_Interaction_3496E064255B4D8E69C4FFFC25AE1A61");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InteractionDurationId).HasColumnName("InteractionDurationID");

                entity.Property(e => e.InteractionStatusId).HasColumnName("InteractionStatusID");

                entity.Property(e => e.InteractionTypeId).HasColumnName("InteractionTypeID");

                entity.Property(e => e.LastModifyDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Interaction)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interacti__Compa__69FBBC1F");

                entity.HasOne(d => d.InteractionDuration)
                    .WithMany(p => p.Interaction)
                    .HasForeignKey(d => d.InteractionDurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interacti__Inter__6AEFE058");

                entity.HasOne(d => d.InteractionStatus)
                    .WithMany(p => p.Interaction)
                    .HasForeignKey(d => d.InteractionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interacti__Inter__6BE40491");

                entity.HasOne(d => d.InteractionType)
                    .WithMany(p => p.Interaction)
                    .HasForeignKey(d => d.InteractionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Interacti__Inter__6CD828CA");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Interaction)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Interacti__UserI__6DCC4D03");
            });

            modelBuilder.Entity<InteractionDuration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InteractionInteractionNatureMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InteractionId).HasColumnName("InteractionID");

                entity.Property(e => e.InteractionNatureId).HasColumnName("InteractionNatureID");

                entity.HasOne(d => d.Interaction)
                    .WithMany(p => p.InteractionInteractionNatureMap)
                    .HasForeignKey(d => d.InteractionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InteractionNatureMap_Interaction");

                entity.HasOne(d => d.InteractionNature)
                    .WithMany(p => p.InteractionInteractionNatureMap)
                    .HasForeignKey(d => d.InteractionNatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InteractionNatureMap_InteractionNature");
            });

            modelBuilder.Entity<InteractionNature>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InteractionStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InteractionType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailQueue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Attachments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CC");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.MessageFile)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MailQueue)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailQueue_Company");
            });

            modelBuilder.Entity<Orm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("__orm__");

                entity.Property(e => e.Databaseguid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("databaseguid");
            });

            modelBuilder.Entity<Path>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Page)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Path1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Path");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommonDataLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.ProductDataLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductConfigurationType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductPathMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.PathId).HasColumnName("PathID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.ProductPathMap)
                    .HasForeignKey(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPathMap_Path");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPathMap)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPathMap_Product");
            });

            modelBuilder.Entity<RegistrationLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdateSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RegistrationLog)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationLog_User");
            });

            modelBuilder.Entity<RemoteAccessEvent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.MessageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MessageID");

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Queue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.RemoteAccessEvent)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RemoteAcc__Event__6166761E");

                entity.HasOne(d => d.EventType)
                    .WithMany(p => p.RemoteAccessEvent)
                    .HasForeignKey(d => d.EventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RemoteAcc__Event__625A9A57");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesForceAccount>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EntityCat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesForceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesForceID");

                entity.Property(e => e.SubCat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany()
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesForceAccount_Company");
            });

            modelBuilder.Entity<SalesForceEvuserLookup>(entity =>
            {
                entity.HasKey(e => e.EvuserId);

                entity.ToTable("SalesForceEVUserLookup");

                entity.Property(e => e.EvuserId)
                    .ValueGeneratedNever()
                    .HasColumnName("EVUserID");

                entity.Property(e => e.SalesForceContactId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesForceContactID");

                entity.Property(e => e.SalesForceContactStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Sqlinfo>(entity =>
            {
                entity.ToTable("SQLInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SqlinstanceName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SQLInstanceName");

                entity.Property(e => e.Sqlversion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SQLVersion");
            });

            modelBuilder.Entity<SqlinfoEventMap>(entity =>
            {
                entity.ToTable("SQLInfoEventMap");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.SqlinfoId).HasColumnName("SQLInfoID");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.SqlinfoEventMap)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SQLInfoEventMap_Event");

                entity.HasOne(d => d.Sqlinfo)
                    .WithMany(p => p.SqlinfoEventMap)
                    .HasForeignKey(d => d.SqlinfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SQLInfoEventMap_SQLInfo");
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvince)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateProvince_Country");
            });

            modelBuilder.Entity<TmpContactChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_CONTACT_CHANGE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewContactId).HasColumnName("NewContactID");

                entity.Property(e => e.OldContactId).HasColumnName("OldContactID");

                entity.Property(e => e.OldContactName)
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpToDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_to_delete");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastValidation).HasColumnType("datetime");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Vsouser)
                    .HasMaxLength(50)
                    .HasColumnName("VSOUser");
            });

            modelBuilder.Entity<TmpVsoToDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_VSO_TO_DELETE");

                entity.Property(e => e.BadVsoaccount)
                    .HasMaxLength(50)
                    .HasColumnName("BadVSOAccount");

                entity.Property(e => e.EmailAddr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMailAddr")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.GoodVsoaccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GoodVSOAccount");
            });

            modelBuilder.Entity<TmpVsodir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_VSODIR");

                entity.Property(e => e.Dirlist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DIRLIST");
            });

            modelBuilder.Entity<TmpVsoserverlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_VSOSERVERLIST");

                entity.HasIndex(e => e.Username, "idx_user")
                    .IsClustered();

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TmpVsouserActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_VSOUserActivity");

                entity.Property(e => e.LastAccess)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpdateFiles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Database).HasMaxLength(256);

                entity.Property(e => e.Md5)
                    .HasMaxLength(128)
                    .HasColumnName("MD5");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UpdateFilesStaging>(entity =>
            {
                entity.ToTable("UpdateFiles_Staging");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Database).HasMaxLength(256);

                entity.Property(e => e.Md5)
                    .HasMaxLength(128)
                    .HasColumnName("MD5");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => new { e.DateDeleted, e.UnlockKey }, "nci_wi_User_2CA9CD565A17273A0867EC2602598096");

                entity.HasIndex(e => new { e.CompanyId, e.DateDeleted, e.IsMainContact }, "nci_wi_User_A6C828388C2F01C5EBD34A06F92E14FE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMainContact).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUserActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MigrationComplete).HasColumnType("datetime");

                entity.Property(e => e.MigrationStart).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OldCompanyId).HasColumnName("OldCompanyID");

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PLACEHOLDER')");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ShipNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sqllogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SQLLogin");

                entity.Property(e => e.Sqlpassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SQLPassword");

                entity.Property(e => e.Subscription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UafupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UAFUpdateDate");

                entity.Property(e => e.UpdateSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PLACEHOLDER')");

                entity.Property(e => e.VsouserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VSOUserName");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_User_Address");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_User_Company");
            });

            modelBuilder.Entity<UserEventMap>(entity =>
            {
                entity.HasIndex(e => e.EventId, "nci_wi_UserEventMap_23414380673CD0013C75673C064768E9");

                entity.HasIndex(e => e.UserId, "nci_wi_UserEventMap_383697FC0861D1148D0448F3E44A95B1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.UserEventMap)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEventMap_Event");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEventMap)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEventMap_User");
            });

            modelBuilder.Entity<UserProductConfigurationTypeMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductConfigurationTypeId).HasColumnName("ProductConfigurationTypeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ProductConfigurationType)
                    .WithMany(p => p.UserProductConfigurationTypeMap)
                    .HasForeignKey(d => d.ProductConfigurationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_P_ConfigurationMap_P_Configuration");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProductConfigurationTypeMap)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductConfigurationMap_User");
            });

            modelBuilder.Entity<UserProductMap>(entity =>
            {
                entity.HasIndex(e => new { e.DateDeleted, e.ProductId, e.UserId }, "nci_wi_UserProductMap_3FBA03B567C6B81A95542D25EDF98DBE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.GraceLoginsAllowed).HasDefaultValueSql("((10))");

                entity.Property(e => e.InstallDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdateSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UserProductMap)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductMap_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProductMap)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductMap_User");
            });

            modelBuilder.Entity<UserRemoteAccessEventMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.RemoteAccessEventId).HasColumnName("RemoteAccessEventID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserRemoteAccessEventMap)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRemot__Compa__7849DB76");

                entity.HasOne(d => d.RemoteAccessEvent)
                    .WithMany(p => p.UserRemoteAccessEventMap)
                    .HasForeignKey(d => d.RemoteAccessEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRemot__Remot__793DFFAF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRemoteAccessEventMap)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRemot__UserI__7A3223E8");
            });

            modelBuilder.Entity<UserRoleMap>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoleMap)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleMap_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleMap)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleMap_User");
            });

            modelBuilder.Entity<Vsouser>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("VSOUser");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.EmailAddr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMailAddr")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldCompanyId).HasColumnName("OldCompanyID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<VsouserActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSOUserActivity");

                entity.HasIndex(e => e.UserName, "VSOUserActivity$UserName")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.LastConfirmedActivity).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsouserDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSOUserDeleted");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VsouserExtended>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("VSOUser_Extended");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAdactive).HasColumnName("IsADActive");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
