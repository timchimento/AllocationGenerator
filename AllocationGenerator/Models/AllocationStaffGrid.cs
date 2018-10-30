using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AllocationGenerator.Models
{

    public partial class AllocationStaffGrid
    {
        public string Emplid { get; set; }
        public decimal? HourstoAllocate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? EffectiveDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ExpirationDate { get; set; }
        public string InsertBy { get; set; }
        public DateTime? InsertDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int AllocationStaffId { get; set; }
        [TempData]
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
