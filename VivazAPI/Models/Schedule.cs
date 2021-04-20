using System;
using System.ComponentModel.DataAnnotations;

namespace VivazAPI.Models
{
    public class Schedule : BaseEntity
    {
        //User
        [Required]
        public Guid EmployeeId { get; set; }

        public User Employee { get; set; }

        //Occurence
        [Required]
        public Guid OccurenceId { get; set; }

        public Occurrence Occurence { get; set; }

        [Required]
        public DateTime ActualStart { get; set; }

        [Required]
        public DateTime ActualEnd { get; set; }
    }
}
