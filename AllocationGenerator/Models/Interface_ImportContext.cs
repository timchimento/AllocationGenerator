using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AllocationGenerator.Models
{
    public partial class Interface_ImportContext : DbContext
    {

        public Interface_ImportContext()
        {
        }

        public Interface_ImportContext(DbContextOptions<Interface_ImportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllocationStaff> AllocationStaff { get; set; }
        public virtual DbSet<EmployeeCeridian> EmployeeCeridian { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

                optionsBuilder.UseSqlServer(connectionString, providerOptions => providerOptions.CommandTimeout(60)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

          
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AllocationStaff>(entity =>
            {
                entity.Property(e => e.AllocationStaffId).HasColumnName("AllocationStaffID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.Emplid)
                    .IsRequired()
                    .HasColumnName("EMPLID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.HourstoAllocate).HasColumnType("decimal(5, 2)");

                entity.Property<DateTime?>("LastUpdateDate").HasColumnType("date");
                entity.Property<string>("LastUpdateBy").HasColumnType("string");

                entity.Property<DateTime?>("InsertDate").HasColumnType("date");
                entity.Property<string>("InsertBy").HasColumnType("string");

                //   modelBuilder.Entity<AllocationStaff>().Property<DateTime>("LastUpdateDate");


                //entity.Property(e => e.InsertBy)
                //    .HasMaxLength(40)
                //    .IsUnicode(false);

                //entity.Property(e => e.InsertDate).HasColumnType("date");

                //entity.Property(e => e.LastUpdateBy)
                //    .HasMaxLength(40)
                //    .IsUnicode(false);

                //entity.Property(e => e.LastUpdateDate).HasColumnType("date");
            });

           // modelBuilder.Entity<AllocationStaff>().Property<DateTime>("LastUpdateDate");

            modelBuilder.Entity<EmployeeCeridian>(entity =>
            {
                entity.ToTable("Employee_Ceridian", "Import");

                entity.Property(e => e.EmployeeCeridianId).HasColumnName("Employee_CeridianID");

                entity.Property(e => e.AddressEffectiveDate).HasColumnType("date");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessEmail)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDepositAccountNumber)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDepositAccountType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDepositAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DirectDepositAmountPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DirectDepositBankCode)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDepositDepositType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDepositPrenoteDate).HasColumnType("date");

                entity.Property(e => e.DirectDepositPrenoteRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDepositPrenoteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DirectDepositSuppressAdvice)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmplEffectiveDate).HasColumnType("date");

                entity.Property(e => e.EmplId)
                    .IsRequired()
                    .HasColumnName("EmplID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Handicapped)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ImportSource)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                //entity.Property(e => e.InsertBy)
                //    .HasMaxLength(40)
                //    .IsUnicode(false);

                //entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateWorked).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                //entity.Property(e => e.LastUpdateBy)
                //    .HasMaxLength(40)
                //    .IsUnicode(false);

                //entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.MailingAddressEffectiveDate).HasColumnType("date");

                entity.Property(e => e.MailingAddressLine1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine2)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddressLine3)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCountry)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MailingPostalCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MailingState)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NameTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PrimarySecondaryJob)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RateChangeEffectiveStart).HasColumnType("date");

                entity.Property(e => e.RateChangeNewPayGroup)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RateChangeNewRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RateChangeNewSalary).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RehireDate).HasColumnType("date");

                entity.Property(e => e.SeniorityDate).HasColumnType("date");

                entity.Property(e => e.ServiceDate).HasColumnType("date");

                entity.Property(e => e.StandardHours).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.State)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorId)
                    .HasColumnName("SupervisorID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TaxpayerId)
                    .HasColumnName("TaxpayerID")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TermReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("date");
            });
        }

        private readonly IHttpContextAccessor _httpContextAccessor;
        private string connectionString;

        public Interface_ImportContext(DbContextOptions<Interface_ImportContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> SaveChangesAsync()
        {

            var UserID = _httpContextAccessor.HttpContext.User.Identity.Name.Split('\\')[1];

            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("InsertDate").CurrentValue = DateTime.UtcNow;
                    entry.Property("InsertBy").CurrentValue = UserID;

                  //  @User.Identity.Name.Split('\\')[1]

                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property("LastUpdateDate").CurrentValue = DateTime.UtcNow;
                    entry.Property("LastUpdateBy").CurrentValue = UserID;
                }
            }
            return await base.SaveChangesAsync();
        }



    }
}
