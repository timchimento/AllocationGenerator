using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AllocationGenerator.Models
{
    public partial class AllocationStaff
    {
        public string Emplid { get; set; }
        [Display(Name = "Hours to Allocate")]
        public decimal? HourstoAllocate { get; set; }
        //[DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? EffectiveDate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ExpirationDate { get; set; }
        public int AllocationStaffId { get; set; }

    }

   
}
