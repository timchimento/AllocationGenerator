using System;
using System.Collections.Generic;

namespace AllocationGenerator.Models
{
    public partial class EmployeeCeridian
    {
        public int EmployeeCeridianId { get; set; }
        public string EmplId { get; set; }
        public DateTime? AddressEffectiveDate { get; set; }
        public DateTime? MailingAddressEffectiveDate { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankAccountType { get; set; }
        public string BankCode { get; set; }
        public string City { get; set; }
        public string MailingCity { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string MailingCountry { get; set; }
        public string County { get; set; }
        public string MailingCounty { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string DeptId { get; set; }
        public DateTime? EmplEffectiveDate { get; set; }
        public string Email { get; set; }
        public string BusinessEmail { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Handicapped { get; set; }
        public DateTime? HireDate { get; set; }
        public string HomePhone { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public DateTime? LastDateWorked { get; set; }
        public DateTime? RateChangeEffectiveStart { get; set; }
        public decimal? RateChangeNewSalary { get; set; }
        public decimal? RateChangeNewRate { get; set; }
        public string RateChangeNewPayGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string MiddleInitial { get; set; }
        public string PostalCode { get; set; }
        public string MailingPostalCode { get; set; }
        public string PrimarySecondaryJob { get; set; }
        public DateTime? RehireDate { get; set; }
        public DateTime? ServiceDate { get; set; }
        public DateTime? SeniorityDate { get; set; }
        public string TaxpayerId { get; set; }
        public decimal? StandardHours { get; set; }
        public string State { get; set; }
        public string MailingState { get; set; }
        public string EmploymentStatus { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string MailingAddressLine1 { get; set; }
        public string MailingAddressLine2 { get; set; }
        public string MailingAddressLine3 { get; set; }
        public string NameSuffix { get; set; }
        public string SupervisorId { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string TermReason { get; set; }
        public string NameTitle { get; set; }
        public string DirectDepositAccountNumber { get; set; }
        public string DirectDepositAccountType { get; set; }
        public decimal? DirectDepositAmount { get; set; }
        public decimal? DirectDepositAmountPercentage { get; set; }
        public string DirectDepositBankCode { get; set; }
        public string DirectDepositDepositType { get; set; }
        public DateTime? DirectDepositPrenoteDate { get; set; }
        public string DirectDepositPrenoteRequired { get; set; }
        public string DirectDepositPrenoteStatus { get; set; }
        public short? DirectDepositAccountPriority { get; set; }
        public string DirectDepositSuppressAdvice { get; set; }
        public string ImportSource { get; set; }
        public DateTime? InsertDate { get; set; }
        public string InsertBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public int? EmployeeChecksum { get; set; }
    }
}
