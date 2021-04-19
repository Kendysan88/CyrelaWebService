using System;
using System.ComponentModel.DataAnnotations;
using VivazAPI.Dtos;

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
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
    }
}
